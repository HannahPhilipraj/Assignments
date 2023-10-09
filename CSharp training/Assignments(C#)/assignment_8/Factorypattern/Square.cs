using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    class Square : IShapes
    {
        double side { get; set; }
        public double GetValue()
        {
            Console.WriteLine("Enter the value for side : ");
            side = Convert.ToInt32(Console.ReadLine());
            return side;
        }
        public double GetArea()
        {
            
            return side * side;
        }

        public double GetPerimeter()
        {
            
            return 4*side;
        }
    }
}
