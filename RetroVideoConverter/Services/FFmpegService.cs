using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RetroVideoConverter.Services
{
    public class FFmpegService
    {
        public Task<int> ConvertAsync(
            string ffmpegPath,
            string arguments,
            Action<string> onLog,
            Action<double> onProgressSeconds)
        {
            if (!File.Exists(ffmpegPath))
                throw new FileNotFoundException("ffmpeg.exe not found", ffmpegPath);

            return Task.Run(() =>
            {
                var psi = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Regex timeRegex = new Regex(@"time=(\d{2}:\d{2}:\d{2}\.\d{2})");

                using (var process = new Process())
                {
                    process.StartInfo = psi;

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrWhiteSpace(e.Data))
                            onLog(e.Data);
                    };

                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (string.IsNullOrWhiteSpace(e.Data))
                            return;

                        onLog(e.Data);

                        Match match = timeRegex.Match(e.Data);
                        if (match.Success)
                        {
                            double seconds = ParseTimeToSeconds(match.Groups[1].Value);
                            onProgressSeconds(seconds);
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    return process.ExitCode;
                }
            });
        }

        private double ParseTimeToSeconds(string value)
        {
            TimeSpan ts;
            if (TimeSpan.TryParse(value, CultureInfo.InvariantCulture, out ts))
                return ts.TotalSeconds;

            return 0.0;
        }
    }
}