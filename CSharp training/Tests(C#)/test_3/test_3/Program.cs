using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3
{
    
    class Cricket
    {
        
        public void PointsCalculation(int no_of_matches)
        {
           
            List<int> scores = new List<int>();
           
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter the score of match {i + 1} : ");
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
                
            }
            Console.WriteLine("The sum of the scores : {0} ",scores.Sum());
            Console.WriteLine("The average of all the scores : {0}",scores.Average());
        }
           
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int matches;
            Console.Write("Enter the no. of matches : ");
            matches = Convert.ToInt32(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(matches);
            Console.ReadLine();

        }
    }
}
