using System;
using System.Collections.Generic;
using System.Data.SqlClient;


/*Using Ado.net classes/methods, insert employee record in the table by invoking the procedure  

Display all the records (including the newely added record)*/

namespace test_01
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Procedure_call();
            Console.Read();
        }
        public void Procedure_call()
        {
            con = Connection();
            try
            {
                Console.Write("Enter Employee Name :");
                string ename = Console.ReadLine();
                Console.Write("Enter Employee Salary(Salary should be greater than 25000) : ");
                float esal = float.Parse(Console.ReadLine());
                Console.Write("Enter Employee job type('F'- full time,'P'- part time) : ");
                char etype = char.Parse(Console.ReadLine());
                cmd = new SqlCommand("Add_Employee @ename,@esal,@etype", con); 
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@esal", esal);
                cmd.Parameters.AddWithValue("@etype", etype);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Employee Name : {dr[0]} \n Employee Salary : {dr[1]}" +
                        $"\n Employee Job Type : {dr[2]} ");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }            
        }
        static SqlConnection Connection()
        {           
            con = new SqlConnection("Data Source=ICS-LT-GH26573;Initial Catalog=Assignments;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
