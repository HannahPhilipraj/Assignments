using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a class Box that has Length and breadth as its members. 
 * Write a function that adds 2 box objects and stores in the 3rd. 
 * Display the 3rd object details. Create a Test class to execute the above.

 */
namespace test3
{
    class Box
    {
        public static double Length1 { get; set; }
        public static double Breadth1 { get; set; }
        public static double Length2 { get; set; }
        public static double Breadth2 { get; set; }
        // public Box Add(Box b1,Box b2)
        //{
        //double newBox1 = b1.Length() + b2.Breadth();
        //double newBox2 = b1.Length() + b2.Breadth();
        //return new Box(newLength, newBreadth);
        //}
    }
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("Enter the length and breadth of box 1 : ");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length and breadth of box 1 : ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            int breadth2 = Convert.ToInt32(Console.ReadLine());

            Box box = new Box();
            //box.Add();




        }
    }
}


       
        
    
