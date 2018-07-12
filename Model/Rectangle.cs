using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Model
{
    public class Rectangle : IShape
    {
        private double Width;
        private double Height;
        public Rectangle(double Width, double Height) 
        {
            this.Width = Width;
            this.Height = Height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public double Circumferences()
        {
            return 2 * (Width + Height);
        }

        public string CreateMsgForList()
        {
            return string.Format("Rectangle: Width={0} , Height={1}\n", Width, Height);
        }
    }
}
