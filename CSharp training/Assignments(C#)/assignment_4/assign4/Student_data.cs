using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign4
{

    class Student
    {
        public static int Rollno, Class, Semester,y;
        internal string studname, branch;
        protected static int[] marks = new int[5];
        public static float avg;
        internal Student(string name,int year,int sem,string degree,int rollnum)
        {
            studname = name;
            Class = year;
            Semester = sem;
            branch = degree;
            Rollno = rollnum;
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Class(1/2/3/4) : "+year);
            Console.WriteLine("Semester(1-8) : "+sem);
            Console.WriteLine("Branch : "+degree);
            Console.WriteLine("Roll no. : "+rollnum);
        }
        public static void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Marks of Subject " + i + " : ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                int x = marks[i];
                y = x;
                if (x < 35)
                    Console.WriteLine("Fail in Subject {0}", i);
                else
                    Console.WriteLine("Pass in Subject {0} ", i);
            }                        
        }
        public static void DisplayResult()
        {
            int total = marks.Sum();
            
            float average = total / 5;
            avg=average;
            Console.WriteLine("Average marks : " + average);
            if (average < 50)
            {
                Console.WriteLine("Average mark is below 50");
            }
            else if (average > 50)
            {
                Console.WriteLine("Average mark is above 50");
            }
            else { }
            
        }
        public static void DisplayData()
        {
            GetMarks();
            DisplayResult();
            if(y>35 && avg>50)
                Console.WriteLine("Result : Pass");           
            else if(y<35 || avg<50)
                Console.WriteLine("Result : Fail");            
            else { }

        }
 
    }
    class Program2
    {
        public static void Main()
        {
            Student student=new Student("Hannah",3,6,"Computer Science",20);
            Student.DisplayData();
            Console.ReadLine();

        }
    }
}
