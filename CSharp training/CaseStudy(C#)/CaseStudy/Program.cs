using System;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scenarios.Scenario1();
            //Scenarios.Scenario2(); 
            Console.WriteLine("Welcome to SMS(Student Management System)");                       
            App app = new App();
            app.showFirstScreen();
            Console.ReadLine();
        }
    }
}
