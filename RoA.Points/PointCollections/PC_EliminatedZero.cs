using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_EliminatedZero
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
new PointCollection()
{
    color = ColorTranslator.FromHtml("#000000"),
    points = new List<Point>()
    {
        new Point(0, 4),
new Point(0, 35),
new Point(4, 0),
new Point(4, 39),
new Point(7, 7),
new Point(7, 32),
new Point(12, 12),
new Point(12, 27),
new Point(15, 12),
new Point(15, 27),
new Point(20, 7),
new Point(20, 32),
new Point(23, 0),
new Point(23, 39),
new Point(27, 4),
new Point(27, 35)
    }
}
            }
        };
    }
}
