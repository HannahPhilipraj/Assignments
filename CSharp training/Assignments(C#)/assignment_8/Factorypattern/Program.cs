using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a shape :");
            string shape = Console.ReadLine();

            IShapes sh = ShapesFactory.GetShape(shape);


            if (sh != null)
            {
                Console.WriteLine("Value : {0}",sh.GetValue());
                Console.WriteLine("Area : {0}", sh.GetArea());
                Console.WriteLine("Perimeter : {0}", sh.GetPerimeter());
               
            }
            else
            {
                Console.WriteLine("Invalid choice.. please give correct type");
            }
            Console.Read();
        }
    }
}
