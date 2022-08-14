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

        public static PointCollectionsGroup CreatePlayerMatchHud(Color hudColor, int slotPosition, int totalSlots)
        {
            if (totalSlots == 2)
            {
                switch (slotPosition)
                {
                    case 1:
                        return CreateHudGroup(new Point(500, 984), hudColor, Group);
                    case 2:
                        return CreateHudGroup(new Point(976, 984), hudColor, Group);
                }
            }
            else if (totalSlots == 3)
            {
                switch (slotPosition)
                {
                    case 1:
                        return CreateHudGroup(new Point(262, 984), hudColor, Group);
                    case 2:
                        return CreateHudGroup(new Point(738, 984), hudColor, Group);
                    case 3:
                        return CreateHudGroup(new Point(1214, 984), hudColor, Group);
                }
            }
            else if (totalSlots == 4)
            {
                switch (slotPosition)
                {
                    case 1:
                        return CreateHudGroup(new Point(24, 984), hudColor, Group);
                    case 2:
                        return CreateHudGroup(new Point(500, 984), hudColor, Group);
                    case 3:
                        return CreateHudGroup(new Point(976, 984), hudColor, Group);
                    case 4:
                        return CreateHudGroup(new Point(1452, 984), hudColor, Group);
                }
            }

            return null;
        }
    }
}
