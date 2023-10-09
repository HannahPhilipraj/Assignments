using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign4
{
    class Accounts
    {
        internal float accnum;
        public string custname,acctype;
        public static double balance;
        
        public Accounts(float acno, string name, string acty,double blnce)
        {
            accnum = acno;
            custname = name;
            acctype = acty;
            balance = blnce;
            Console.WriteLine("Account no. : "+ acno);
            Console.WriteLine("Customer name : "+ name);
            Console.WriteLine("Account type : "+ acty);
            Console.WriteLine("Your Balance : " + blnce);
        }
        
        public static void Credit(double amt)
        {
            Console.WriteLine("The amount to be deposited is "+ amt);           
            balance = balance+amt;
            
        }
        public static void Debit(double amt)
        {
            Console.WriteLine("The amount to be withdrawn is "+ amt);          
            balance = balance - amt;
            
        }
        
        public static void Showdata()
        {
            char a;
            Console.Write("Select the transaction type(d/w): " );
            a = char.Parse(Console.ReadLine());
            if (a.Equals('d')||a.Equals('D'))
                Accounts.Credit(2000);
            else if (a.Equals('w')||a.Equals('W'))
                Accounts.Debit(1500);
            else
                Console.WriteLine("Invalid input");
            Console.WriteLine("Your current balance is : Rs.{0}", balance); 

        }
    }
    class Program
    {
        public static void Main()
        {
            Accounts account = new Accounts(1560, "Hannah", "Savings account", 30000);
            Accounts.Showdata();           
            Console.ReadLine();
        }
    }
}
