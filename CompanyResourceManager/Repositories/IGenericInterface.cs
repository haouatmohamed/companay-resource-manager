using System;
using System.Collections.Generic;
using System.Text;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public interface IGenericInterface<T>
    {
        public long AddEmployee(T employeeDto);

        public Employee GetEmployeeById(long id);

        public IEnumerable<Manager> GetAllEmployee();

        public void Save();

        public IEnumerable<Employee> GetEmployeesBySalary(double salary);
    }
}
