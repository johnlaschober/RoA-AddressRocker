using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoA.Screen
{
    public static class ScreenTools
    {
        public static Bitmap CaptureFromScreen(Rectangle rect)
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

            return bmpScreenCapture;
        }

        public static Color GetColorFromScreen(Point p)
        {
            Rectangle rect = new Rectangle(p, new Size(1, 1));

            Bitmap map = CaptureFromScreen(rect);

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

            return foundPoints;
        }

        public static double GetMatchingPercentage(Bitmap screen, PointCollectionsGroup group)
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
                }
                totalPoints += collection.points.Count;
            }


            double foundRatio = (double)((double)matching / (double)totalPoints * 100d);
            return foundRatio;
        }
    }
}
