using System;

namespace RetroVideoConverter.Helpers
{
    public static class ResolutionHelper
    {
        public static (int width, int height) CalculateFit(
            int sourceWidth,
            int sourceHeight,
            int maxWidth,
            int maxHeight)
        {
            if (sourceWidth <= 0 || sourceHeight <= 0)
                return (maxWidth, maxHeight);

            double ratioX = (double)maxWidth / sourceWidth;
            double ratioY = (double)maxHeight / sourceHeight;
            double ratio = Math.Min(ratioX, ratioY);

            int width = (int)(sourceWidth * ratio);
            int height = (int)(sourceHeight * ratio);

            if (width < 2) width = 2;
            if (height < 2) height = 2;

            if (width % 2 != 0) width--;
            if (height % 2 != 0) height--;

            return (width, height);
        }
    }
}