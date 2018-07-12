using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx.Model
{
    public class ShapeFactory
    {

      
        public IShape createShape(int UserChoice, List<double> parameters)
        {
            if (UserChoice == (int)Constants.e_Shapes.Square)
            {
                return new Square(parameters[0]);
            }
            else if (UserChoice == (int)Constants.e_Shapes.Rectangle)
            {
                return new Rectangle(parameters[0], parameters[1]);
            }
            else if (UserChoice == (int)Constants.e_Shapes.Circle)
            {
                return new Circle(parameters[0]);
            }
            else if (UserChoice == (int)Constants.e_Shapes.RightTriangle)
            {
                return new RightTriangle(parameters[0], parameters[1]);
            }

            return null;
        }
                
                
        
    }
}
