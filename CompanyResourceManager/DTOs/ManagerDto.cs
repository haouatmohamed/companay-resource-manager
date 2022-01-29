using CompanyResourceManager.Models;

namespace CompanyResourceManager.DTOs
{
    public sealed class ManagerDto
    {
        public ManagerDto(string name, Team team, double salary)
        {
            Name = name;
            Team = team;
            Salary = salary;
        }

        public string Name { get; }
        public Team Team { get; }
        public double Salary { get; }
    }
}
