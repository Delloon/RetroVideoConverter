using RetroVideoConverter.Models;
using System;

namespace RetroVideoConverter.Helpers
{
    public static class FFmpegArgumentBuilder
    {
        public static string Build(
            string inputPath,
            string outputPath,
            ResolutionPreset preset,
            EncoderOption videoEncoder,
            string formatExtension,
            bool keepAspectRatio,
            int sourceWidth,
            int sourceHeight)
        {
            int width = preset.MaxWidth;
            int height = preset.MaxHeight;

            string videoCodec = videoEncoder.EncoderName;
            string audioCodec = "aac";
            string extraArgs = "";

            if (formatExtension.Equals("3gp", StringComparison.OrdinalIgnoreCase))
            {
                if (videoCodec != "h263" && videoCodec != "mpeg4")
                    videoCodec = "mpeg4";

                audioCodec = "aac";
                extraArgs += " -r 12 ";
            }

            if (videoCodec == "h263")
            {
                width = preset.MaxWidth;
                height = preset.MaxHeight;
            }
            else
            {
                if (keepAspectRatio)
                {
                    var size = ResolutionHelper.CalculateFit(
                        sourceWidth,
                        sourceHeight,
                        preset.MaxWidth,
                        preset.MaxHeight);

                    width = size.width;
                    height = size.height;
                }
                else
                {
                    width = preset.MaxWidth;
                    height = preset.MaxHeight;
                }
            }

            return
                "-y -i \"" + inputPath + "\" " +
                "-vf scale=" + width + ":" + height + " " +
                "-c:v " + videoCodec + " " +
                "-c:a " + audioCodec + " " +
                extraArgs +
                "\"" + outputPath + "\"";
        }
    }
}