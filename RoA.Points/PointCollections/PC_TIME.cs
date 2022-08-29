using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_TIME
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
new PointCollection()
{
    color = ColorTranslator.FromHtml("#CF4949"),
    points = new List<Point>()
    {
        new Point(543, 435),
new Point(616, 438),
new Point(702, 438),
new Point(789, 459),
new Point(878, 436),
new Point(1028, 441),
new Point(1125, 441),
new Point(1264, 437),
new Point(1355, 459)
    }
},
new PointCollection()
{
    color = ColorTranslator.FromHtml("#EA8E8E"),
    points = new List<Point>()
    {
        new Point(564, 568),
new Point(728, 560),
new Point(805, 576),
new Point(902, 561),
new Point(968, 573),
new Point(1056, 577),
new Point(1072, 540),
new Point(1180, 577),
new Point(1298, 574)
    }
},
new PointCollection()
{
    color = ColorTranslator.FromHtml("#000000"),
    points = new List<Point>()
    {
        new Point(657, 503),
new Point(675, 389),
new Point(1044, 503),
new Point(1253, 495)
    }
}
            }
        };
    }
}
