using System.Collections.Generic;
using System.Drawing;

namespace RoA.Points.PointCollections
{
    public static class PC_PlayerMatchHud // HUD in P1 vs P2
    {
        private static PointCollectionsGroup Group = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
                new PointCollection() // Black border
                {
                    color = Color.Black,
                    points = new List<Point>()
                    {
                        new Point(0, 20),
                        new Point(0, 75),
                        new Point(4, 8),
                        new Point(4, 87),
                        new Point(8, 4),
                        new Point(8, 91),
                        new Point(12, 0),
                        new Point(12, 95),
                        new Point(435, 0),
                        new Point(435, 95),
                        new Point(439, 4),
                        new Point(439, 91),
                        new Point(443, 8),
                        new Point(443, 87),
                        new Point(447, 20),
                        new Point(447, 75)
                    }
                },
                new PointCollection() // Red color
                {
                    color = ColorTranslator.FromHtml("#ED1C24"),
                    points = new List<Point>()
                    {
                        new Point(9, 32),
                        new Point(9, 68),
                        new Point(59, 32),
                        new Point(61, 84),
                        new Point(169, 7),
                        new Point(175, 85),
                        new Point(294, 90),
                        new Point(316, 7),
                        new Point(394, 87),
                        new Point(400, 60),
                        new Point(439, 33),
                        new Point(440, 64)
                    }
                }
            }
        };

        private static PointCollectionsGroup SinglePointGroup = new PointCollectionsGroup()
        {
            collections = new List<PointCollection>()
            {
new PointCollection()
{
    color = ColorTranslator.FromHtml("#ED1C24"),
    points = new List<Point>()
    {
        new Point(11, 27),
new Point(12, 36),
new Point(13, 17),
new Point(17, 23),
new Point(21, 32),
new Point(25, 87),
new Point(36, 88),
new Point(44, 88),
new Point(52, 32),
new Point(55, 87),
new Point(58, 37),
new Point(61, 22),
new Point(62, 33),
new Point(383, 7),
new Point(397, 74),
new Point(398, 63),
new Point(399, 82),
new Point(400, 67),
new Point(401, 58),
new Point(403, 87),
new Point(414, 52),
new Point(415, 86),
new Point(418, 8),
new Point(425, 54),
new Point(428, 80),
new Point(431, 65),
new Point(434, 14),
new Point(435, 27),
new Point(436, 41),
new Point(436, 51),
new Point(436, 71),
new Point(437, 33),
new Point(439, 58)
    }
}
            }
        };

        private static PointCollectionsGroup CreateHudGroup(Point hudStart, Color newColor, PointCollectionsGroup group)
        {
            PointCollectionsGroup localGroup = PointHelper.GetGroupClone(group);
            localGroup.collections[localGroup.collections.Count - 1].color = newColor;
            foreach (var pc in localGroup.collections)
            {
                for (int i = 0; i < pc.points.Count; i++)
                {
                    pc.points[i] = new Point(pc.points[i].X + hudStart.X, pc.points[i].Y + hudStart.Y);
                }
            }

            return localGroup;
        }

        public static PointCollectionsGroup P1Hud(bool isCPU) // 1 v 1
        {
            return CreateHudGroup(new Point(500, 984), isCPU ? ColorTranslator.FromHtml("#808080") : ColorTranslator.FromHtml("#ED1C24"), Group);
        }

        public static PointCollectionsGroup P1HudColor(bool isCPU)
        {
            return CreateHudGroup(new Point(500, 984), isCPU ? ColorTranslator.FromHtml("#808080"): ColorTranslator.FromHtml("#ED1C24"), SinglePointGroup);
        }

        public static PointCollectionsGroup P2Hud(bool isCPU) // 1 v 1
        {
            return CreateHudGroup(new Point(976, 984), isCPU ? ColorTranslator.FromHtml("#808080") : ColorTranslator.FromHtml("#00B7EF"), Group);
        }

        public static PointCollectionsGroup P2HudColor(bool isCPU)
        {
            return CreateHudGroup(new Point(976, 984), isCPU ? ColorTranslator.FromHtml("#808080"): ColorTranslator.FromHtml("#00B7EF"), SinglePointGroup);
        }
    }
}
