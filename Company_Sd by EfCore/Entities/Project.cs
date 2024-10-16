namespace ConsoleApp4.Entities
{
    public class Project
    {
        public int Pnum { get; set; }
        public string PName { get; set; }
        public string City { get; set; }
        public string Loc { get; set; }
        public int ? Dnum { get; set; }

        public Department Departments { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public ICollection<MyWork> MyWorks { get; set; }
    }


    }
