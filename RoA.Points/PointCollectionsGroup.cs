using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points
{
    public class PointCollectionsGroup
    {
        public List<PointCollection> collections;

        public PointCollectionsGroup(List<PointCollection> collections)
        {
            this.collections = collections;
        }

        public PointCollectionsGroup()
        {
            this.collections = new List<PointCollection>();
        }
    }
}
