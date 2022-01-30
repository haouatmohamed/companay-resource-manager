using System;
using System.Collections.Generic;
using System.Text;
using CompanyResourceManager.DTOs;
using CompanyResourceManager.Models;

namespace CompanyResourceManager.Repositories
{
    public  class GenericRepository:IGenericInterface
    {
        public long AddEmployee(EmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(long id)
        {
            throw new NotImplementedException();
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
