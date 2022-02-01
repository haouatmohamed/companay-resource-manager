using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public  class GenericRepository<T>:IGenericInterface<T>
    {
        private readonly List<T> _employees;

        public GenericRepository(List<T> employees)
        {
            this._employees = employees;
        }


        public long AddEmployee(T employeeDto)
        {
            var id = _employees.Max(employee => employee.Id);
            _employees.Add(new Employee(id + 1, employeeDto.Name, employeeDto.Team, employeeDto.Salary));
            return id;
        }

        public Employee GetEmployeeById(long id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }

        public IEnumerable<Manager> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeesBySalary(double salary)
        {
            throw new NotImplementedException();
        }
    }
}
