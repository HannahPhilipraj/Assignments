using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    class Program1
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter a word: ");
            word=Console.ReadLine();
            int a = word.Length;
            Console.WriteLine("The length of the word is : "+a);
            char[] wordarr = word.ToCharArray();
            Array.Reverse(wordarr);
            string wordrev = new string(wordarr);
            Console.WriteLine("The reverse of the word is : "+wordrev);
            Program2.Same();           
            Console.Read();            
        }
    }   
    class Program2
    {
        public static void Same()
        {
            string word1,word2;
            Console.WriteLine("Enter 1st word: ");
            word1=Console.ReadLine();
            Console.WriteLine("Enter 2nd word: ");
            word2 = Console.ReadLine();          
            if(word1==word2)           
                Console.WriteLine("The two words are same");
            else
                Console.WriteLine("The two words are not the same");
        }
           
    }
}
