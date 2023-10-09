using System;

namespace assign5
{
    class Customer
    {
        int custid { get; set; }
        static int age;
        static long phoneno;
        static string name;
        string city { get; set; }
        public Customer()
        {
            custid = 15780;
        }
        public Customer(string Name, int Age, long Phonenum)
        {
            name = Name;
            age = Age;
            phoneno = Phonenum;
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public static void DisplayCustomer()
        {
            Customer details = new Customer();
            details.City = "Chennai";
            Console.WriteLine("Customer ID : " + details.custid);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Phone number : " + phoneno);
            Console.WriteLine("City : " + details.city);
        }
        ~Customer()
        {
            Console.WriteLine("Destructor is used");
            Console.ReadLine();
        }
    }
    class Program4
    {
        public static void Main()
        {
            Customer customer = new Customer("Hannah", 20, 9435835093);
            Customer.DisplayCustomer();
        }
    }

}
