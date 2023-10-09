using System;


namespace ConcessionDLL
{
    public class Concession       
    {
        const int totalfare = 600;
        public void CalculateConcession(int age)
        {
            
            if(age<=5)
            {
                Console.WriteLine("The ticket is free for your lil champ");               
            }
            else if(age>60)
            {                
                double concession = totalfare-(totalfare * 0.3);                             
                Console.WriteLine("You have a concession of 30%");
                Console.WriteLine("Senior citizen ticket fare : "+concession);
            }
            else
            {            
                Console.WriteLine("Your fare is Rs.600");
            }
            Console.WriteLine("Ticket booked successfully");
        }
    }
}
