using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_VersusModeSettings
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
                new PointCollection()
                {
                    points = new List<Point>()
                    {
                        new Point(806, 131),
new Point(823, 112),
new Point(824, 146),
new Point(853, 130),
new Point(872, 129),
new Point(901, 114),
new Point(932, 143),
new Point(964, 112),
new Point(1002, 141),
new Point(1042, 114),
new Point(1077, 128),
new Point(1114, 113)
                    }
                },
                new PointCollection()
                {
                    color = ColorTranslator.FromHtml("#4A3A82"),
                    points = new List<Point>()
                    {
                        new Point(568, 94),
new Point(568, 440),
new Point(568, 985),
new Point(696, 916),
new Point(742, 160),
new Point(925, 94),
new Point(928, 985),
new Point(1190, 160),
new Point(1270, 916),
new Point(1351, 94),
new Point(1351, 404),
new Point(1351, 985)
                    }
                }
            }
        };
    }
}
