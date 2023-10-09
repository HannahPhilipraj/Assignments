using System;

/*Write a console program that uses delegates to call Calculator Functionalities 
 * like 1. Addition, 2. Subtraction and 3. Multiplication by 
 * taking 2 integers and returns the answer to the user. 
 * You should display the return values accordingly.*/
namespace test_4
{
    public delegate int Calculate(int num1, int num2);
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class Program2
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Calculate add = new Calculate(calculator.Add);
            Calculate sub= new Calculate(calculator.Subtract);
            Calculate multiply = new Calculate(calculator.Multiply);
            Console.WriteLine("Enter two integers");
            Console.Write("Integer 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Integer 2 : ");
            int n2 = int.Parse(Console.ReadLine());
            
            int sum = add(n1, n2);
            Console.WriteLine("Addition of the integers : " + sum);
           
            int diff = sub(n1, n2);
            Console.WriteLine("Subtraction result: " + diff);
            
            int product = multiply(n1, n2);
            Console.WriteLine("Multiplication result: " + product);
            Console.ReadLine();
        }
    }
}
