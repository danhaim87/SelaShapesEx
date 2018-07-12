using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelaShapesEx
{
    public interface IShape
    {
        
        double Area();
        double Circumferences();
        string CreateMsgForList();
    }
}
