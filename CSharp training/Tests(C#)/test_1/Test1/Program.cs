using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Removestring("Python",1));
            Console.WriteLine(Removestring("Python",0));
            Console.WriteLine(Removestring("Python",4));
            Console.WriteLine("--------------");
            Multiply();
            Console.ReadLine();
        }
        public static string Removestring(string str,int i)
        {
             string removed=str.Remove(i, 1);
             return (removed);
        }
        public static void Multiply()
        {
            int num;
            Console.WriteLine("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < 11; j++)
            {
                int ans = num * j;
                Console.WriteLine("{0} * {1} = {2}",num,j,ans);
            }
            Console.ReadLine();
        }
    }
}
