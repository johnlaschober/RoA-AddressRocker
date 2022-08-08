using RoA.Points.PointCollections;
using RoA.Screen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points.PointObjects
{
    public class PO_CSSSlot
    {
        private int playerNumber = -1;
        private PointCollectionsGroup group;
        private Color activeColor = Color.White;

        public PO_CSSSlot(int playerNumber)
        {
            this.playerNumber = playerNumber;

            Point slotStart = new Point(0, 0);
            if (playerNumber == 1)
            {
                slotStart = new Point(28, 632);
                activeColor = ColorTranslator.FromHtml("#ED1C24");
            }
            if (playerNumber == 2)
            {
                slotStart = new Point(504, 632);
                activeColor = ColorTranslator.FromHtml("#00B7EF");
            }

            group = PointHelper.GetGroupClone(PC_CSSSlot.Group);

            for (int i = 0; i < group.collections[0].points.Count; i++)
            {
                var uneditedPoint = group.collections[0].points[i];
                group.collections[0].points[i] = new Point(uneditedPoint.X + slotStart.X, uneditedPoint.Y + slotStart.Y);
            }
        }

        public string GetSlotType(Bitmap screen)
        {
            group.collections[0].color = activeColor;
            double dblActive = ScreenTools.GetMatchingPercentage(screen, group);
            if (dblActive > 50) return "HMN";

            group.collections[0].color = ColorTranslator.FromHtml("#808080"); // CPU gray
            double dblComputer = ScreenTools.GetMatchingPercentage(screen, group);
            if (dblComputer > 50) return "CPU";

            return "OFF";
        }
    }
}
