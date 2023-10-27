using System;
using System.Data;
using System.Data.SqlClient;

namespace CaseStudy
{    
   class Student
   {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
       
        public static void Student_enrollment()
        {
            con = new SqlConnection("Data Source=ICS-LT-GH26573;Initial Catalog=Tests;" +
                "Integrated Security=True");
            con.Open();
            try
            {
                Console.WriteLine("Here are the list of courses");
                Course.All_Courses();
                Console.WriteLine("Please enroll yourself");
                Console.Write("Enter Student ID : ");
                int stdid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Name : ");
                string stdname = Console.ReadLine();
                Console.Write("Enter Student Date of Birth(YYYY-MM-DD) : ");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                cmd = new SqlCommand("insert into students values(@id,@name,@dob)", con);
                cmd.Parameters.AddWithValue("@id", stdid);
                cmd.Parameters.AddWithValue("@name", stdname);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.ExecuteNonQuery();
                Console.Write("Enter Course ID : ");
                int cid = int.Parse(Console.ReadLine());
                DateTime enrolldate = DateTime.Now;
                SqlCommand cmd1 = new SqlCommand("insert into enrollment values(@sid,@cid,@edate)", con);
                cmd1.Parameters.AddWithValue("@sid", stdid);
                cmd1.Parameters.AddWithValue("@cid", cid);
                cmd1.Parameters.AddWithValue("@edate", enrolldate);
                cmd1.ExecuteNonQuery();
                Console.WriteLine("Registeration completed successfully");
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void Enrolled_Students()
        {
            con = new SqlConnection("Data Source=ICS-LT-GH26573;Initial Catalog=Tests;" +
           "Integrated Security=True");
            con.Open();
                cmd = new SqlCommand("select * from Enrollment", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine("==============================================================");
                Console.WriteLine("Student ID  |    Course ID     |    Enrollment Date");
                Console.WriteLine("==============================================================");
                while (dr.Read())
                {
                    Console.WriteLine("{0}          |    {1}           | {2}  ", dr[0], dr[1],dr[2]);
                }
                con.Close();                        
        }
   }     
}
