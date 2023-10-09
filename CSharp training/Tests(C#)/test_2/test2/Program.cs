using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Product
    {
        int productid;
        public string productname;
        public void AcceptProducts()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Enter a product :");
                productname = Console.ReadLine();
                Console.WriteLine("Enter the product Id : ");
                productid = Convert.ToInt32(Console.ReadLine());
                
            }
            
        }
        public void DisplayProducts()
        {
            Console.WriteLine("The prices are : ");
            List<int> price = new List<int>() { 34,46,45,46,78,78,89,90,155,56 };
            Console.WriteLine(price);
            int[] array = price.ToArray();
            price.Sort();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.AcceptProducts();
            product.DisplayProducts();
            Console.ReadLine();
        }
    }
}
