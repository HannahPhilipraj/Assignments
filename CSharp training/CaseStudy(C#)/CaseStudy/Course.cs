using System;
using System.Data.SqlClient;

namespace CaseStudy
{
    class Course
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static SqlConnection Connection()
        {
            con = new SqlConnection("Data Source=ICS-LT-GH26573;Initial Catalog=Tests;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void All_Courses()
        {
            con = Connection();
            cmd = new SqlCommand("select * from Courses",con);           
            dr = cmd.ExecuteReader();
            Console.WriteLine("====================================");
            Console.WriteLine("Course ID   |    Course Name");
            Console.WriteLine("====================================");
            while (dr.Read())
            {               
                Console.WriteLine("{0}        |    {1}",dr[0],dr[1]);                              
            }
            con.Close();
        }
        public static void Introduce_Courses()
        {
            con = Connection();
            try
            {               
                Console.Write("Enter the number of courses you want to introduce :");
                int count = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<count;i++)
                {                    
                    Console.Write("Enter Course Name : ");
                    string cname = Console.ReadLine();
                    cmd = new SqlCommand("Add_Course @cname", con);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    Console.WriteLine($"Course {i+1} added");
                    dr = cmd.ExecuteReader();
                }
                dr.Close();
                Console.WriteLine("Course(s) added successfully");
                All_Courses();
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

   
   