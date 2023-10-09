using System;
using System.IO;
namespace test_4
{
    class Program1
    {
        public static void Write()
        {
            FileStream filestream = new FileStream("TestProgram1.Txt", FileMode.Append,
                FileAccess.Write);
            StreamWriter streamwriter = new StreamWriter(filestream);           
            Console.WriteLine("Enter the Data to be written :");            
            string str = Console.ReadLine();            
            streamwriter.Write(str);            
            streamwriter.Close();
            filestream.Close();
        }
        static void Main(string[] args)
        {
            Write();
        }
    }
}
