﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace CircularCloud
{
    public static class RectanglePainter
    {
        public static void DrawRectanglesInFile(IEnumerable<Rectangle> rectangles, string path = "")
        {
            var image = new Bitmap(2000, 2000);
            var g = Graphics.FromImage(image);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 2000, 2000));
            foreach (var rectangle in rectangles)
            {
                g.FillRectangle(new SolidBrush(Color.Chartreuse), rectangle);
                g.DrawRectangle(new Pen(Color.Red, 3), rectangle);
            }

            g.Save();
            image.Save(path + "visualisation.png", ImageFormat.Png);
        }
    }
}