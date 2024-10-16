using ConsoleApp4.Data;
using ConsoleApp4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Seed Departments
            if (!context.Departments.Any())
            {
                var departments = new[]
                {
                    new Department { Dum = 1, DName = "Human Resources", MgrSsn = 1001 },
                    new Department { Dum = 2, DName = "IT", MgrSsn = 1004 },
                    new Department { Dum = 3, DName = "Finance", MgrSsn = 1007 },
                    new Department { Dum = 4, DName = "Marketing", MgrSsn = null},
                    new Department { Dum = 5, DName = "Sales", MgrSsn = 1010 },
                    new Department { Dum = 6, DName = "Research and Development", MgrSsn = 1011 }
                };
                context.Departments.AddRange(departments);
                context.SaveChanges();
            }

            // Seed Employees
            if (!context.Employees.Any())
            {
                var employees = new[]
                {
                    new Employee { Ssn = 1001, FirstName = "Alice", LastName = "Smith", Gender = "Female", Dnum = 1, SuperId = null },
                    new Employee { Ssn = 1002, FirstName = "Bob", LastName = "Johnson", Gender = "Male", Dnum = 1, SuperId = 1001 },
                    new Employee { Ssn = 1003, FirstName = "Charlie", LastName = "Brown", Gender = "Male", Dnum = 2, SuperId = 1004 },
                    new Employee { Ssn = 1004, FirstName = "David", LastName = "Williams", Gender = "Male", Dnum = 2, SuperId = null },
                    new Employee { Ssn = 1005, FirstName = "Eve", LastName = "Davis", Gender = "Female", Dnum = 3, SuperId = 1007 },
                    new Employee { Ssn = 1006, FirstName = "Frank", LastName = "Garcia", Gender = "Male", Dnum = 3, SuperId = 1007 },
                    new Employee { Ssn = 1007, FirstName = "Grace", LastName = "Martinez", Gender = "Female", Dnum = 1, SuperId = 1001 },
                    new Employee { Ssn = 1008, FirstName = "Hank", LastName = "Wilson", Gender = "Male", Dnum = 4, SuperId = 1008 },
                    new Employee { Ssn = 1009, FirstName = "Ivy", LastName = "Rodriguez", Gender = "Female", Dnum = 4, SuperId = 1008 },
                    new Employee { Ssn = 1010, FirstName = "Jack", LastName = "Lopez", Gender = "Male", Dnum = 5, SuperId = 1010 },
                    new Employee { Ssn = 1011, FirstName = "Kara", LastName = "Hernandez", Gender = "Female", Dnum = 5, SuperId = 1010 },
                    new Employee { Ssn = 1012, FirstName = "Liam", LastName = "Clark", Gender = "Male", Dnum = 6, SuperId = 1011 },
                    new Employee { Ssn = 1013, FirstName = "Mia", LastName = "Lewis", Gender = "Female", Dnum = 6, SuperId = 1011 },
                    new Employee { Ssn = 1014, FirstName = "Noah", LastName = "Walker", Gender = "Male", Dnum = 6, SuperId = 1011 }
                };
                context.Employees.AddRange(employees);
                context.SaveChanges();
            }

            // Seed Dependents
            if (!context.Dependents.Any())
            {
                var dependents = new[]
                {
                    new Dependent { Ssn = 1001, DeptName = "Human Resources", Gender = "Female" },
                    new Dependent { Ssn = 1002, DeptName = "Human Resources", Gender = "Male" },
                    new Dependent { Ssn = 1005, DeptName = "Finance", Gender = "Female" },
                    new Dependent { Ssn = 1006, DeptName = "Finance", Gender = "Male" },
                    new Dependent { Ssn = 1008, DeptName = "Marketing", Gender = "Female" },
                    new Dependent { Ssn = 1009, DeptName = "Marketing", Gender = "Male" },
                    new Dependent { Ssn = 1010, DeptName = "Sales", Gender = "Female" },
                    new Dependent { Ssn = 1011, DeptName = "Sales", Gender = "Male" },
                    new Dependent { Ssn = 1012, DeptName = "R&D", Gender = "Female" },
                    new Dependent { Ssn = 1013, DeptName = "R&D", Gender = "Female" }
                };
                context.Dependents.AddRange(dependents);
                context.SaveChanges();
            }

            // Seed Locations
            if (!context.Locations.Any())
            {
                var locations = new[]
                {
                    new Location { Dnum = 1, loc = "Building A" },
                    new Location { Dnum = 2, loc = "Building B" },
                    new Location { Dnum = 3, loc = "Building C" },
                    new Location { Dnum = 4, loc = "Building D" },
                    new Location { Dnum = 5, loc = "Building E" },
                    new Location { Dnum = 6, loc = "Building F" }
                };
                context.Locations.AddRange(locations);
                context.SaveChanges();
            }

            // Seed Projects
            if (!context.Projects.Any())
            {
                var projects = new[]
                {
                    new Project { Pnum = 1, PName = "Employee Management System", City = "New York", Loc = "Building A", Dnum = 1 },
                    new Project { Pnum = 2, PName = "Inventory System", City = "Los Angeles", Loc = "Building B", Dnum = 2 },
                    new Project { Pnum = 3, PName = "Financial Reporting", City = "Chicago", Loc = "Building C", Dnum = 3 },
                    new Project { Pnum = 4, PName = "Customer Relationship Management", City = "San Francisco", Loc = "Building A", Dnum = 1 },
                    new Project { Pnum = 5, PName = "Website Redesign", City = "Seattle", Loc = "Building D", Dnum = 4 },
                    new Project { Pnum = 6, PName = "Sales Forecasting", City = "Dallas", Loc = "Building E", Dnum = 5 },
                    new Project { Pnum = 7, PName = "Product Development", City = "Austin", Loc = "Building F", Dnum = 6 }
                };
                context.Projects.AddRange(projects);
                context.SaveChanges();
            }

            // Seed MyWork
            if (!context.MyWorks.Any())
            {
                var myWork = new[]
                {
                    new MyWork { Ssn = 1002, PNum = 1, Hours = 40 },
                    new MyWork { Ssn = 1003, PNum = 2, Hours = 35 },
                    new MyWork { Ssn = 1005, PNum = 3, Hours = 45 },
                    new MyWork { Ssn = 1006, PNum = 4, Hours = 30 },
                    new MyWork { Ssn = 1007, PNum = 1, Hours = 50 },
                    new MyWork { Ssn = 1008, PNum = 5, Hours = 38 },
                    new MyWork { Ssn = 1009, PNum = 5, Hours = 42 },
                    new MyWork { Ssn = 1010, PNum = 6, Hours = 36 },
                    new MyWork { Ssn = 1011, PNum = 6, Hours = 48 },
                    new MyWork { Ssn = 1012, PNum = 7, Hours = 40 },
                    new MyWork { Ssn = 1013, PNum = 7, Hours = 45 },
                    new MyWork { Ssn = 1014, PNum = 7, Hours = 55 }
                };
                context.MyWorks.AddRange(myWork);
                context.SaveChanges();
            }
        }
    }
}
