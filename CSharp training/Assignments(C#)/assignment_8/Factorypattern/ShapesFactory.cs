using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    public class ShapesFactory
    {
        public static IShapes GetShape(string shape)
        {
            IShapes Icc = null;
            if (shape == "Square")
            {
                Icc = new Square();
            }
            else if (shape == "Circle")
            {
                Icc = new Circle();
            }
            return Icc;
        }
    }
}
