using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points
{
    public static class ScreenTools
    {
        public static Bitmap CaptureFromScreen(Rectangle rect, Size? resize)
        {
            Bitmap bmpScreenCapture = null;

            if (rect == Rectangle.Empty)
            {
                rect = new Rectangle(0, 0, 1920, 1080);
            }

            bmpScreenCapture = new Bitmap(rect.Width, rect.Height);

            Graphics p = Graphics.FromImage(bmpScreenCapture);


            p.CopyFromScreen(rect.X,
                     rect.Y,
                     0, 0,
                     rect.Size,
                     CopyPixelOperation.SourceCopy);

            p.Dispose();

            if (resize != null)
            {
                Bitmap bmpResized = ResizeImage(bmpScreenCapture, resize.Value.Width, resize.Value.Height);
                bmpScreenCapture.Dispose();
                return bmpResized;
            }

            return bmpScreenCapture;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Color GetColorFromScreen(Point p)
        {
            Rectangle rect = new Rectangle(p, new Size(1, 1));

            Bitmap map = CaptureFromScreen(rect, null);

            Color c = map.GetPixel(0, 0);

            map.Dispose();
            return c;
        }

        public static List<Point> MatchCoordsFromBitmap(string imagePath, Color colorToFind)
        {
            List<Point> foundPoints = new List<Point>();

            Image img = Image.FromFile(imagePath);
            Bitmap bmp = new Bitmap(img);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    if (pixel.R == colorToFind.R &&
                        pixel.G == colorToFind.G &&
                        pixel.B == colorToFind.B)
                    {
                        foundPoints.Add(new Point(i, j));
                    }
                }
            }

            bmp.Dispose();

            return foundPoints;
        }

        public static string GetCodeStringFromBitmaps(string uneditedPath, string editedPath)
        {
            Color colorToFind = ColorTranslator.FromHtml("#4CFF00");

            Image imgUnedited = Image.FromFile(uneditedPath);
            Image imgEdited = Image.FromFile(editedPath);

            Bitmap bmpUnedited = new Bitmap(imgUnedited);
            Bitmap bmpEdited = new Bitmap(imgEdited);

            Dictionary<Color, List<Point>> dctPixels = new Dictionary<Color, List<Point>>();

            for (int i = 0; i < bmpEdited.Width; i++)
            {
                for (int j = 0; j < bmpEdited.Height; j++)
                {
                    Color editedPixel = bmpEdited.GetPixel(i, j);
                    if (editedPixel.R == colorToFind.R &&
                        editedPixel.G == colorToFind.G &&
                        editedPixel.B == colorToFind.B)
                    {
                        Color uneditedPixel = bmpUnedited.GetPixel(i, j);

                        if (!dctPixels.ContainsKey(uneditedPixel))
                        {
                            dctPixels[uneditedPixel] = new List<Point>();
                        }
                        dctPixels[uneditedPixel].Add(new Point(i, j));
                    }
                }
            }

            string returnString = "";

            foreach (var color in dctPixels.Keys)
            {
                string hexColor = ColorToHex(color);

                returnString += @"new PointCollection()
{
    color = ColorTranslator.FromHtml(HEX_COLOR),
    points = new List<Point>()
    {
        POINTS_LIST
    }
}," + Environment.NewLine;

                returnString = returnString.Replace("HEX_COLOR", $"\"{hexColor}\"");

                string pointsText = "";
                foreach (var point in dctPixels[color])
                {
                    pointsText += $"new Point({point.X}, {point.Y})," + Environment.NewLine;
                }
                pointsText = pointsText.TrimEnd('\n');
                pointsText = pointsText.Substring(0, pointsText.Length - 2);

                returnString = returnString.Replace("POINTS_LIST", pointsText);
            }

            return returnString;
        }

        private static string ColorToHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }


        public static double GetMatchingPercentage(Bitmap screen, PointCollectionsGroup group, bool checkWhite = false)
        {
            int matching = 0;
            int totalPoints = 0;

            foreach (var collection in group.collections)
            {
                foreach (Point p in collection.points)
                {
                    Color foundColor = screen.GetPixel(p.X, p.Y);
                    if (foundColor.R == collection.color.R &&
                        foundColor.G == collection.color.G &&
                        foundColor.B == collection.color.B)
                    {
                        matching++;
                    }
                    else if (checkWhite)
                    {
                        if (foundColor.R == Color.White.R &&
                            foundColor.G == Color.White.G &&
                            foundColor.B == Color.White.B)
                        {
                            matching++;
                        }
                    }
                }
                totalPoints += collection.points.Count;
            }


            double foundRatio = (double)((double)matching / (double)totalPoints * 100d);
            return foundRatio;
        }
    }
}
