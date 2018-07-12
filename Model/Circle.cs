using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Model
{
    public class Circle : IShape
    {
        private double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public double CircleRadius
        {
            get { return Radius; }
        }

        public double Area()
        {
            return Constants.Pi * Radius * Radius;
        }

        public double Circumferences()
        {
            return 2 * Constants.Pi * Radius;
        }

        public string CreateMsgForList()
        {
            return string.Format("Circle: Radius={0}\n", Radius);
        }
    }
}
