using System;

namespace CaseStudy
{
    interface UserInterface
    {
		void ShowFirstScreen();
		void ShowStudentScreen();
		void ShowAdminScreen();
		void ShowAllStudentsScreen();
		void ShowStudentRegistrationScreen(); 
		void IntroduceNewCourseScreen();
		void ShowAllCoursesScreen();
	}
    class SMS : UserInterface
    {       
        public void ShowFirstScreen()
        {
            Console.WriteLine("Your choices are \n1.Student\n2.Admin\n3.Exit");
            Console.Write("Enter your choice(1/2/3): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowStudentScreen(); break;                   
                case 2:
                    ShowAdminScreen(); break;
                case 3: break;
                default:
                    Console.WriteLine("Invalid input...please enter 1 or 2 or 3"); break;
            }
        }
        public void ShowStudentScreen()
        {
            Console.WriteLine("-----Student Screen-----");
            Console.WriteLine("What do you want to do?\n1.Show all courses\n2.Register details\n3.Exit");
            Console.Write("Enter your choice(1/2/3) : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
                case 3: break;
                default:
                    Console.WriteLine("Invalid input"); break;
            }
        }        
        public void ShowAdminScreen()
        {
            Console.WriteLine("-----Admin Screen-----");
            Console.WriteLine("What do you want to do?\n1.Show all students\n2.Show all courses\n3.Introduce new courses\n4.Exit");
            Console.Write("Enter your choice(1/2/3/4) : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    ShowAllStudentsScreen(); break;
                case 2:
                    ShowAllCoursesScreen();
                    ShowAdminScreen();
                    break;
                case 3:
                    IntroduceNewCourseScreen(); break;
                case 4: break;
                default:
                    Console.WriteLine("Invalid input"); break;
            }
        }
        public void ShowStudentRegistrationScreen()
        {
            Console.WriteLine("-----Registration-----");
            Student.Student_enrollment();          
            ShowStudentScreen();
        }
        public void ShowAllCoursesScreen()
        {
            Console.WriteLine("-----List of courses-----");
            Course.All_Courses();          
        }

        public void ShowAllStudentsScreen()
        {
            Console.WriteLine("-----Enrolled Students-----");
            Student.Enrolled_Students();
            ShowAdminScreen();
        }
        public void IntroduceNewCourseScreen()
        {
            Course.Introduce_Courses();
            ShowAdminScreen();
        }            
    }
}
