using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    abstract class Student
    {
        string studentname { get; set; }
        int studentid { get; set; } 
        int grade;
        public abstract bool Boolen_Ispassed(int grade);
        
        
    }

    class Undergraduate : Student
    {
        
        public override bool Boolean_Ispassed(int grade)
        {
            bool ans=grade>70;
            
            return ans;
            
        }
  
    }
    class Graduate : Student
    {
       
        public override bool Boolean_Ispassed(int grade)
        {
            bool ans=grade>80;
            
            return ans;
        }


    }
    class Program1
    {
        public static void Main()
        {

            Undergraduate ug = new Undergraduate()
            {
                studentname = "Hannah",
                studentid = 4874,
                grade = 75
            };
            
            bool value=ug.Boolean_Ispassed(value.grade);
            Graduate grad = new Graduate()
            {
                studentname = "Harini",
                studentid = 7804,
                grade = 79
            };
            bool pg = grad.Boolen_Ispassed(pg.grade);
            
            Console.ReadLine();
        }
    }
}
