using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    class Circle : IShapes
    {
        int radius { get; set; }
        public double GetValue()
        {
            Console.Write("Enter the radius : ");
            radius = Convert.ToInt32(Console.ReadLine());
            return radius;
        }
        public double GetArea()
        {
            
            return 3.14 * radius * radius;
        }

        public double GetPerimeter()
        {
            
            return 3.14 * radius *2;
        }
    }
}
