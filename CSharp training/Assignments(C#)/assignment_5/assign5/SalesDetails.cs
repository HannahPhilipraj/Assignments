using System;

namespace assign5
{
    class SalesDetails
    {
        public double Price { get; set; }
        public double salesno, totalamount;
        internal int productno, quantity;
        DateTime dateofsale { get; } = Convert.ToDateTime("2023/09/15");
        public SalesDetails(double salesnum, int productnum, int qty)
        {
            salesno = salesnum;
            productno = productnum;
            this.Price = 980;
            quantity = qty;
            Console.WriteLine("Sales number : " + salesnum);
            Console.WriteLine("Product number : " + productnum);
            Console.WriteLine("Price : Rs." + Price);
            Console.WriteLine("Quantity : " + qty);
            Console.WriteLine("Date of sale : " + dateofsale);
        }
        public void Sales()
        {
            totalamount = quantity * Price;
        }
        public void ShowData()
        {
            Console.WriteLine("Total amount :Rs." + totalamount);
        }
    }

    class Program3
    {
        public static void Main()
        {
            SalesDetails details = new SalesDetails(3807, 437, 3);
            details.Sales();
            details.ShowData();
            Console.ReadLine();
        }

    }
}




