using NodaTime;
using System;
using System.Collections.Generic;

namespace CaseStudy
{
    public class Course
    {
        public int course_id { get; set; }
        public string course_name { get; set; }
        public Course(int courseId, string courseName)
        {
            this.course_id = courseId;
            this.course_name = courseName;
        }
    }
    public class Enroll
    {
        private Student enroll_student;
        private Course enroll_course;
        private LocalDate enrollmentdate;
        public Enroll(Student stud,Course course,LocalDate enroll_date)
        {
            this.enroll_student = stud;
            this.enroll_course = course;
            this.enrollmentdate = enroll_date;
        }
    } 
    class AppEngine
    {
        List<Student> students = new List<Student>();                
        public void Introduce(Course course)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Course Introduced");
            Console.WriteLine($"Course ID : {course.course_id}\nCourse Name : {course.course_name}");                      
        }        
        public void ListofCourses()
        {
            List<Course> courses = new List<Course>()
            {
               new Course(1001,"Java Programming"),new Course(1002,"Statistics"),new Course(1003,"Micro Biology"),
               new Course(1004,"English"),new Course(1005,"Psychology")
            };
            foreach (var course in courses)
            {
                Info.Display2(course);
            }
        }
        public void Enroll(Student student,Course course)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("******************");
            Console.WriteLine("Student enrollment in course");
            Console.WriteLine($"Student ID : {student.student_id}\nStudent Name : {student.student_name}" +
                $"\nStudent Date Of Birth : {student.student_dob}" +
                $"\nCourse ID : {course.course_id}\nCourse Name : {course.course_name}"+
                $"\nEnrollment Date :{dateTime}"); 
        }
    }
}
