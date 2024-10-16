using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entities
{
    public class Employee
    {

        public int Ssn { get; set; }
      
        public string Gender { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ? Dnum { get; set; }
        public int ? SuperId{ get; set; }

        public Employee Supervise{ get; set; }
        public  ICollection<Employee> Employees { get; set; }

        public  Department Departments { get; set; }
        public  Department Departments2 { get; set; }

        public ICollection<Dependent> Dependents{ get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<MyWork> MyWorks { get; set; }



    }

 }
