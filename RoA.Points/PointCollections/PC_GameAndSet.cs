using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_GameAndSet
    {
        public static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
new PointCollection()
{
    color = ColorTranslator.FromHtml("#FDD256"),
    points = new List<Point>()
    {
        new Point(335, 470),
new Point(371, 461),
new Point(397, 467),
new Point(891, 697),
new Point(911, 685),
new Point(927, 692),
new Point(1090, 463),
new Point(1097, 459),
new Point(1112, 469),
new Point(1153, 685),
new Point(1157, 693),
new Point(1162, 685)
    }
},
new PointCollection()
{
    color = ColorTranslator.FromHtml("#000000"),
    points = new List<Point>()
    {
        new Point(366, 492),
new Point(414, 501),
new Point(533, 273),
new Point(626, 498),
new Point(688, 500),
new Point(843, 274),
new Point(895, 720),
new Point(1092, 491),
new Point(1154, 718),
new Point(1169, 277),
new Point(1286, 500),
new Point(1374, 499)
    }
}
            }
        };
    }
}
