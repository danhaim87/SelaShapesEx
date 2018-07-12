using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Model
{
    public class Square : IShape
    {
        private double Width;
        public Square(double Width) 
        {
            this.Width = Width;
        }
        public double WidthProp
        {
            get { return Width; }
        }
        public double Area()
        {
            return Width * Width;
        }

        public double Circumferences()
        {
            return Width * 4;
        }

        public string CreateMsgForList()
        {
            return string.Format("Square: Width={0}\n", Width);
        }
    }
}
