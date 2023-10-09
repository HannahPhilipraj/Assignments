using System;
using System.Linq;
using static System.Console;
namespace assign2
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10, 20, 70, 37, 13 };
            int total = 0;
            for(int i = 0;i < 5;i++)
            {
                total += arr1[i];
            }
            float avg = total / 5;
            WriteLine($"The average value of the array elements is : {avg}");
            WriteLine("The max value is : " + arr1.Max());
            WriteLine("The min value is : " + arr1.Min());
            WriteLine("-----------");
            Program2.Marks();
            ReadLine();
        }
    }
    class Program2
    {
        public static void Marks()
        {
            int[] marks = new int[10];
            for (int i = 0; i < 10; i++) //Assigning value
            {
                Write("Enter the mark: ");              
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }                      
            for ( int i = 0; i < 10; i++)  // Displaying value
            {
               WriteLine(marks[i]+ "   ");
            }
            int tot = 0;
            for (int i = 0; i < 10; i++)
            {
                tot += marks[i];
            }
            WriteLine("Total : " + tot);
            WriteLine("Average : " + marks.Average());
            WriteLine("Minimum mark : " + marks.Min());
            WriteLine("Maximum mark : " + marks.Max());
            Array.Sort(marks);  // Sorts marks in ascending order
            WriteLine("Marks in ascending order: ");
            foreach (int i in marks)
            {
                Write( i +"  ");
            }
            Array.Reverse(marks);
            WriteLine();
            WriteLine("Marks in descending order : ");
            foreach(int j in marks)
            {
                Write(j + "  ");
            }
            ReadLine();           
        }
    }
}
