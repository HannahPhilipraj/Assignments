using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment_01
{
    class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
        public static List<Employees> EmployeeList()
        {
            List<Employees> emplist = new List<Employees>()
            {
             new Employees
            {
                EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager",
                DOB = DateTime.Parse("1984-11-16"), DOJ = DateTime.Parse("2011-6-8"), City = "Mumbai"
            },
             new Employees
            {
                EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager",
                DOB = DateTime.Parse("1984-8-20"), DOJ = DateTime.Parse("2012-7-7"), City = "Mumbai"
            },
            new Employees
            {
                EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant",
                DOB = DateTime.Parse("1987-11-14"), DOJ = DateTime.Parse("2015-4-12"), City = "Pune"
            },
            new Employees
            {
                EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE",
                DOB = DateTime.Parse("1990-6-3"), DOJ = DateTime.Parse("2016-2-2"), City = "Pune"
            },
            new Employees
            {
                EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE",
                DOB = DateTime.Parse("1991-3-8"), DOJ = DateTime.Parse("2016-2-2"), City = "Mumbai"
            },
            new Employees
            {
                EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant",
                DOB = DateTime.Parse("1989-11-7"), DOJ = DateTime.Parse("2014-8-8"), City = "Chennai"
            },
            new Employees
            {
                EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant",
                DOB = DateTime.Parse("1989-12-2"), DOJ = DateTime.Parse("2015-6-1"), City = "Mumbai"
            },
            new Employees
            {
                EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate",
                DOB = DateTime.Parse("1993-11-11"), DOJ = DateTime.Parse("2014-11-6"), City = "Chennai"
            },
            new Employees
            {
                EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate",
                DOB = DateTime.Parse("1992-8-12"), DOJ = DateTime.Parse("2014-12-3"), City = "Chennai"
            },
            new Employees
            {
                EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager",
                DOB = DateTime.Parse("1991-4-12"), DOJ = DateTime.Parse("2016-1-2"), City = "Pune"
            }

            };
            return emplist;                 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            var doj = from j in Employees.EmployeeList()
                       where j.DOJ<DateTime.Parse("2015-1-1")
                       select new { j.FirstName, j.LastName };
            Console.WriteLine("List of all the employee who have joined before 1/1/2015");
            foreach (var i in doj)
            {                
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            }
            Console.WriteLine("--------------------");

            var dob = from b in Employees.EmployeeList()
                      where b.DOB > DateTime.Parse("1990-1-1")
                      select new { b.FirstName, b.LastName };
            Console.WriteLine("List of all the employee whose date of birth is after 1/1/1990");
            foreach (var i in dob)
            {
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            }
            Console.WriteLine("--------------------");

            var designation = from d in Employees.EmployeeList()
                              where d.Title == ("Consultant") || d.Title==("Associate")
                              select new{ d.FirstName, d.LastName };
            Console.WriteLine("List of all the employee whose designation is Consultant and Associate");
            foreach (var i in designation)
            {
                Console.WriteLine($"{i.FirstName} {i.LastName}");
            }
            Console.WriteLine("---------------------");

            int total = Employees.EmployeeList().Count();
            Console.WriteLine("Total number of employees : {0}",total);            
            Console.WriteLine("----------------------");

            int chennai = Employees.EmployeeList().FindAll(c=>c.City=="Chennai").Count();
            Console.WriteLine($"Total number of employees belonging to “Chennai” : {chennai}");
            Console.WriteLine("----------------------");

            int highest = Employees.EmployeeList().Max(h=>h.EmployeeID);
            Console.WriteLine($"The highest employee id from the list : {highest}");
            Console.WriteLine("----------------------");

            int totemp = Employees.EmployeeList().FindAll(t=>t.DOJ>DateTime.Parse("2015-1-1")).Count();
            Console.WriteLine($"Total number of employees who have joined after 1/1/2015 : {totemp}");
            Console.WriteLine("----------------------");

            int design = Employees.EmployeeList().FindAll(a => a.Title != "Associate").Count();
            Console.WriteLine($"Total number of employees whose designation is not “Associate” : {design}");
            Console.WriteLine("----------------------");
            
            var cities = Employees.EmployeeList().GroupBy(c => c.City).Select(c =>new {city=c.Key,count=c.Count()});
            Console.WriteLine("Total number of employees based on City");
            foreach(var c in cities)
                Console.WriteLine($"City : {c.city} \t  Count : {c.count}");
            Console.WriteLine("----------------------");

            var titlecity = Employees.EmployeeList().GroupBy(tc => new { tc.City, tc.Title }).
                Select(t => new { city = t.Key, title = t.Key, count = t.Count() });
            Console.WriteLine("Total number of employees based on city and title");
            foreach(var t in titlecity)
                Console.WriteLine($"City and Title : {t.title} \t  Count : {t.count}");
            Console.WriteLine("-----------------------");

            var young = Employees.EmployeeList().Min(y =>DateTime.Compare(DateTime.Now,y.DOB));
            Console.WriteLine($"Total number of employees who is youngest in the list : {young}");
            Console.ReadLine();
        }
    }
}

