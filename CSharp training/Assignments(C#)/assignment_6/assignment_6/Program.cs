using System;
using ConcessionDLL;

namespace assignment_6
{
    class Program
    {
               
        public string Name { get; set; }
        public int Age { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of tickets to be booked");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Program details = new Program();
                Console.Write("Enter the name : ");
                details.Name = Console.ReadLine();
                Console.Write("Enter the age : ");
                details.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name : "+details.Name);
                Console.WriteLine("Age : "+details.Age);
                Concession concession = new Concession();
                concession.CalculateConcession(details.Age);

            }            
            Console.ReadLine();
        }
    }
    
}
