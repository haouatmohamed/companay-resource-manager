using System;
using System.Collections.Generic;
using System.Linq;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public sealed class ManagerRepository
    {
        private readonly List<Manager> _managers;

        public ManagerRepository()
        {
            _managers = new List<Manager>();
        }

        public long AddEmployee(ManagerDto managerDto)
        {
            var id = _managers.Max(manager => manager.Id);
            _managers.Add(new Manager(id + 1, managerDto.Name, managerDto.Team, managerDto.Salary));
            return id;
        }

        public Manager GetEmployeeById(long id)
        {
            return _managers.FirstOrDefault(manager => manager.Id == id);
        }

        public IEnumerable<Manager> GetAllEmployee()
        {
            return _managers.ToArray();
        }

        public IEnumerable<Manager> GetManagersBySalary(double salary)
        {
            return _managers.Where(manager => Math.Abs(manager.Salary - salary) < 0.1);
        }
        public void Save()
        {
            _managers.ForEach(manager =>
            {
                Console.WriteLine($"{manager.Id}: {manager.Name}, {manager.Team}, {manager.Salary}");
            });
        }
    }
}
