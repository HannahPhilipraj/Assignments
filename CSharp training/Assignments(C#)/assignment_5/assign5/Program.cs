using System;

namespace assign5
{
    class Program1_2
    {
        public static string firstname, lastname;
        public static void Display()
        {
            Console.Write("Enter your first name : ");
            firstname = Console.ReadLine();
            Console.Write("Enter your last name : ");
            lastname = Console.ReadLine();
            Console.WriteLine("Before converting to upper case");
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine("After converting to uppercase");
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.ToUpper());
        }
        public void NoofOccurences()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the letter to be counted : ");
            char c = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    count += 1;
            }
            Console.WriteLine(c + " occurs " + count + " times");
        }
        static void Main()
        {
            Program1_2.Display();
            Console.WriteLine("----------");
            Program1_2 noofoccurences = new Program1_2();
            noofoccurences.NoofOccurences();
            Console.ReadLine();
        }
    }
}
