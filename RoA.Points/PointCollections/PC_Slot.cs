using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_Slot
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
                new PointCollection()
                {
                    points = new List<Point>()
                    {
                        new Point(5, 121),
                        new Point(6, 264),
                        new Point(10, 9),
                        new Point(15, 352),
                        new Point(203, 355),
                        new Point(249, 8),
                        new Point(426, 10),
                        new Point(430, 229),
                        new Point(433, 316),
                        new Point(435, 123)
                    }
                }
            }
        };
    }
}
