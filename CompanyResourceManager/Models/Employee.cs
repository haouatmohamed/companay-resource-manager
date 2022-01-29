namespace CompanyResourceManager.Models
{
    public sealed class Employee
    {
        public Employee(long id, string name, Team team, double salary)
        {
            Id = id;
            Name = name;
            Team = team;
            Salary = salary;
        }

        public long Id { get; }
        public string Name { get; }
        public Team Team { get; }
        public double Salary { get; }


    }
}
