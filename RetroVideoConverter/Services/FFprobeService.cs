using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace RetroVideoConverter.Services
{
    public class FFprobeService
    {
        public Task<Tuple<int, int>> GetVideoSizeAsync(string ffprobePath, string inputPath)
        {
            return Task.Run(() =>
            {
                if (!File.Exists(ffprobePath))
                    return Tuple.Create(0, 0);

                var psi = new ProcessStartInfo
                {
                    FileName = ffprobePath,
                    Arguments = "-v error -select_streams v:0 -show_entries stream=width,height -of csv=s=x:p=0 \"" + inputPath + "\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = psi;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                        return Tuple.Create(0, 0);

                    output = output.Trim();

                    string[] parts = output.Split('x');
                    if (parts.Length != 2)
                        return Tuple.Create(0, 0);

                    int width;
                    int height;

                    if (!int.TryParse(parts[0], out width))
                        width = 0;

                    if (!int.TryParse(parts[1], out height))
                        height = 0;

                    return Tuple.Create(width, height);
                }
            });
        }
    }
}