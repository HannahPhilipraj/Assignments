using System;
using static System.Console;
namespace assign1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            WriteLine($"The 1st number: {num1} ");
            int num2 = 5;
            WriteLine($"The 2nd number: {num2}");
            if (num1 == num2)
                WriteLine($"{num1} and {num2} are equal");
            else
                WriteLine($"{num1} and {num2} are not equal");
            WriteLine("---------");
            Program2.PosOrNeg();
            WriteLine("---------");
            Program3.PerformOperations(20,12);
            ReadLine();
        }
    }
    class Program2
    {
        public static void PosOrNeg()
        {
             int n1 = 14;
             if(n1 > 0)
                 WriteLine($"{n1} is a positive number");
             else
                 WriteLine($"{n1} is a negative number");
        }
    }
    class Program3
    {
        public static void PerformOperations(int a, int b)
        {
            WriteLine($"The 1st number is : {a}");
            WriteLine($"The 2nd number is : {b}");
            int sum = a + b;
            int diff = a - b;
            int mul = a * b;
            int div = a / b;
            WriteLine($"{a} + {b} = {sum}");
            WriteLine($"{a} - {b} = {diff}");
            WriteLine($"{a} * {b} = {mul}");
            WriteLine($"{a} / {b} = {div}");        
        }
    }
}
