namespace ConsoleApp4.Entities
{
    public class Department
    {
        public int Dum {  get; set; }
        public string DName { get; set; }
        public int ? MgrSsn { get; set; }

        public  ICollection<Employee> Employees { get; set; }

        public  Employee Employees2 { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<Project> Projects { get; set; }
    }

    

}
