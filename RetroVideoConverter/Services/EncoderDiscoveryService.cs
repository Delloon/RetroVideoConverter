using RetroVideoConverter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace RetroVideoConverter.Services
{
    public class EncoderDiscoveryService
    {
        public List<EncoderOption> GetAvailableEncoders(string ffmpegPath)
        {
            List<EncoderOption> result = new List<EncoderOption>();

            if (!File.Exists(ffmpegPath))
                return result;

            List<string> encodersFromFfmpeg = GetEncodersFromFfmpeg(ffmpegPath);

            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "h263", "H.263 (CPU)", false);
            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "mpeg4", "MPEG-4 Part 2 (CPU)", false);
            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "libx264", "H.264 x264 (CPU)", false);

            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "h264_nvenc", "H.264 NVENC (NVIDIA)", true);
            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "h264_qsv", "H.264 QSV (Intel)", true);
            AddIfSupported(result, encodersFromFfmpeg, ffmpegPath, "h264_amf", "H.264 AMF (AMD)", true);

            return result;
        }

        private List<string> GetEncodersFromFfmpeg(string ffmpegPath)
        {
            List<string> result = new List<string>();

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = ffmpegPath;
            psi.Arguments = "-hide_banner -encoders";
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                if (process == null)
                    return result;

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                string all = output + Environment.NewLine + error;
                string[] lines = all.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

                int i;
                for (i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    line = line.Trim();

                    if (!line.StartsWith("V"))
                        continue;

                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2)
                        continue;

                    result.Add(parts[1]);
                }
            }

            return result;
        }

        private void AddIfSupported(
            List<EncoderOption> target,
            List<string> ffmpegEncoders,
            string ffmpegPath,
            string encoderName,
            string displayName,
            bool isHardware)
        {
            if (!ffmpegEncoders.Contains(encoderName))
                return;

            bool ok;

            if (isHardware)
                ok = TestHardwareEncoder(ffmpegPath, encoderName);
            else
                ok = true;

            if (!ok)
                return;

            target.Add(new EncoderOption
            {
                EncoderName = encoderName,
                DisplayName = displayName,
                IsHardware = isHardware
            });
        }

        private bool TestHardwareEncoder(string ffmpegPath, string encoderName)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = ffmpegPath;
            psi.Arguments =
                "-hide_banner -f lavfi -i color=c=black:s=128x128:d=1:r=1 " +
                "-frames:v 1 -c:v " + encoderName + " -f null -";
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                if (process == null)
                    return false;

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode != 0)
                    return false;

                string all = (output + " " + error).ToLowerInvariant();

                if (all.Contains("no device"))
                    return false;

                if (all.Contains("cannot load"))
                    return false;

                if (all.Contains("unsupported"))
                    return false;

                if (all.Contains("error initializing"))
                    return false;

                if (all.Contains("failed"))
                    return false;

                return true;
            }
        }
    }
}