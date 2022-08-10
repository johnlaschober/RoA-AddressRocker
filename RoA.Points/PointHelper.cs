using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points
{
    public static class PointHelper
    {
        public static PointCollectionsGroup GetGroupClone(PointCollectionsGroup toClone)
        {
            PointCollectionsGroup newGroup = new PointCollectionsGroup();
            foreach (var collection in toClone.collections)
            {
                PointCollection newCollection = new PointCollection();
                foreach (var point in collection.points)
                {
                    newCollection.points.Add(new System.Drawing.Point(point.X, point.Y));
                }
                newCollection.color = collection.color;
                newGroup.collections.Add(newCollection);
            }
            return newGroup;
        }

        public static void SlideGroup(Point startPoint, ref PointCollectionsGroup toShift)
        {
            for (int i = 0; i < toShift.collections.Count; i++)
            {
                for (int j = 0; j < toShift.collections[i].points.Count; j++)
                {
                    var uneditedPoint = toShift.collections[i].points[j];
                    toShift.collections[i].points[j] = new Point(uneditedPoint.X + startPoint.X, uneditedPoint.Y + startPoint.Y);
                }
            }
        }
    }
}
