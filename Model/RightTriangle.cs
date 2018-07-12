using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Model
{
    public class RightTriangle : IShape
    {
        private double Width;
        private double Height;

        public RightTriangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        
        }
        public double Area()
        {
            return (Width * Height / 2);
        }

        public double Circumferences()
        {
            return (Width + Height + Math.Sqrt(Width * Width + Height * Height));
        }

        public string CreateMsgForList()
        {
            return string.Format("Right Triangle: Width={0}, Hieght={1}\n", Width, Height);
        }
    }
}
