using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoA.Points
{
    public class PointCollection
    {
        public List<Point> points;
        public Color color;

        public PointCollection(List<Point> points, Color color)
        {
            this.points = points;
            this.color = color;
        }

        public PointCollection(Color color)
        {
            this.points = new List<Point>();
            this.color = color;
        }

        public PointCollection()
        {
            this.points = new List<Point>();
            this.color = Color.White;
        }
    }
}
