﻿using System.Drawing;
using System.Drawing.Imaging;

namespace Health32David.Backend.Common.Clases
{
    public class Helper
    {
        public static Image ImageChangeSize(Image originalImage, int newWidth, int newHeight)
        {

            using (Bitmap originalBMP = new Bitmap(originalImage))
            {
                ImageFormat originalFormat = originalBMP.RawFormat;

                Bitmap bmpOut = new Bitmap(newWidth, newHeight);
                Graphics g = Graphics.FromImage(bmpOut);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.FillRectangle(Brushes.White, 0, 0, newWidth, newHeight);
                g.DrawImage(originalBMP, 0, 0, newWidth, newHeight);
                return (Image)bmpOut;

            }
        }
    }
}
