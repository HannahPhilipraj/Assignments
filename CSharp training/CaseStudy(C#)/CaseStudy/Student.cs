using System;

namespace CaseStudy
{
    public class Student
    {
        public int student_id{ get; set; }
        public string student_name { get; set; }
        public DateTime student_dob { get; set; }
        public Student(int id,string name,DateTime dob)
        {
            student_id = id;
            student_name = name;
            student_dob = dob;
        }
    }
    class Info
    {
        public static void Display1(Student student)
        {
            Console.WriteLine($"Student ID : {student.student_id}\nStudent Name : {student.student_name}" +
                $"\nStudent Date of birth : {student.student_dob}");
            Console.WriteLine("************");
        }
        public static void Display2(Course course)
        {
            Console.WriteLine($"Course ID : {course.course_id}\nCourse Name : {course.course_name}");
            Console.WriteLine("***************");
        }
    }
    class Scenarios
    {
        public static void Scenario1()
        {
            Student student1 = new Student(101, "Abinaya", DateTime.Parse("2002-01-20"));
            Student student2 = new Student(102, "Abinesh", DateTime.Parse("2001-04-24"));
            Student student3 = new Student(103, "Abilash", DateTime.Parse("2002-09-13"));
            Info.Display1(student1);
            Info.Display1(student2);
            Info.Display1(student3);
        }
        public static void Scenario2()
        {
            Student[] student_array = new Student[2];
            student_array[0] = new Student(104, "Akshay", new DateTime(2002,11,25));
            student_array[1] = new Student(105, "Adhanya", new DateTime(2001,12,21));
            foreach (Student student in student_array)
            {
                Info.Display1(student);
            }
        }
    }
}
