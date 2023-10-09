using System;

namespace CaseStudy
{
    interface UserInterface
    {
		void showFirstScreen();
		void showStudentScreen();
		void showAdminScreen();
		void showAllStudentsScreen();
		void showStudentRegistrationScreen(); 
		void introduceNewCourseScreen();
		void showAllCoursesScreen();
	}
    class App : UserInterface
    {
        AppEngine appengine = new AppEngine();
        public void showFirstScreen()
        {
            Console.WriteLine("Your choices are \n1.Student\n2.Admin\n3.Exit");
            Console.Write("Enter your choice(1/2/3): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    showStudentScreen(); break;                   
                case 2:
                    showAdminScreen(); break;
                case 3: break;
                default:
                    Console.WriteLine("Invalid input...please enter 1 or 2 or 3"); break;
            }
        }
        public void showStudentScreen()
        {
            Console.WriteLine("Student Screen");
            Console.WriteLine("What do you want to do?\n1.Register details\n2.Show all courses\n3.Exit");
            Console.Write("Enter your choice(1/2/3) : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    showStudentRegistrationScreen(); break;
                case 2:
                    showAllCoursesScreen();
                    showStudentScreen();
                    break;
                case 3: break;
                default:
                    Console.WriteLine("Invalid input"); break;
            }
        }        
        public void showAdminScreen()
        {
            Console.WriteLine("Admin Screen");
            Console.WriteLine("What do you want to do?\n1.Show all students\n2.Show all courses\n3.Introduce new courses\n4.Exit");
            Console.Write("Enter your choice(1/2/3/4) : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    showAllStudentsScreen(); break;
                case 2:
                    showAllCoursesScreen();
                    showAdminScreen();
                    break;
                case 3:
                    introduceNewCourseScreen(); break;
                case 4: break;
                default:
                    Console.WriteLine("Invalid input"); break;
            }
        }
        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Registration");
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Student ID :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter your Date of Birth(yyyy-dd-mm) : ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            Student student = new Student(id, name, dob);
            Console.Write("Enter the Course ID : ");
            int cid = int.Parse(Console.ReadLine());            
            Console.Write("Enter the Course Name : ");
            string cname = Console.ReadLine();
            Course course = new Course(cid, cname);            
            appengine.Enroll(student, course);
            showStudentScreen();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of courses");           
            appengine.ListofCourses();            
        }

        public void showAllStudentsScreen()
        {
            Scenarios.Scenario1();
            Scenarios.Scenario2();
            showAdminScreen();
        }
        public void introduceNewCourseScreen()
        {
            Console.Write("Enter the no. of course(s) you want to introduce : ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter the Course ID : ");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Course Name : ");
                string cname = Console.ReadLine();
                Course course=new Course(cid, cname);
                appengine.Introduce(course);
            }
            showAdminScreen();
        }            
    }
}
