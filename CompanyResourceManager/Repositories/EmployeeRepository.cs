using System;
using System.Collections.Generic;
using System.Linq;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public sealed class EmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository(List<Employee> employees)
        {
            this._employees = employees;
        }

        public long AddEmployee(EmployeeDto employeeDto)
        {
            var id = _employees.Max(employee => employee.Id);
            _employees.Add(new Employee(id + 1, employeeDto.Name, employeeDto.Team, employeeDto.Salary));
            return id;
        }

        public Employee GetEmployeeById(long id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employees.ToArray();
        }

        public IEnumerable<Employee> GetEmployeesBySalary(double salary)
        {
            return _employees.Where(employee => Math.Abs(employee.Salary - salary) < 0.1);
        }
        public void Save()
        {
            _employees.ForEach(employee =>
            {
                Console.WriteLine($"{employee.Id}: {employee.Name}, {employee.Team}, {employee.Salary}");
            });
        }
    }
}
