using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoA.Screen;

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
    }
}
