using System;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to SMS(Student Management System)");                       
            SMS sms = new SMS();
            sms.ShowFirstScreen();
            Console.ReadLine();
        }
    }
}
