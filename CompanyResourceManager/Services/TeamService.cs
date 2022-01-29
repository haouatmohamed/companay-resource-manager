using System.Collections.Generic;
using System.Linq;
using CompanyResourceManager.Models;
using CompanyResourceManager.Repositories;

namespace CompanyResourceManager.Services
{
    public sealed class TeamService
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly ManagerRepository _managerRepository;
        public TeamService(EmployeeRepository employeeRepository, ManagerRepository managerRepository)
        {
            _employeeRepository = employeeRepository;
            _managerRepository = managerRepository;
        }

        public IEnumerable<Employee> GetAllDevelopmentTeamMembers()
        {
            return _employeeRepository.GetAllEmployee().Where(employee => employee.Team.Value == "Development");
        }
        public IEnumerable<Employee> GetAllHrTeamMembers()
        {
            return _employeeRepository.GetAllEmployee().Where(employee => employee.Team.Value == "Hr");
        }
        public IEnumerable<Employee> GetAllSupportTeamMembers()
        {
            return _employeeRepository.GetAllEmployee().Where(employee => employee.Team.Value == "Support");
        }

        public Manager GetHrTeamManager()
        {
            return _managerRepository.GetAllEmployee().FirstOrDefault(manager => manager.Team.Value == "Hr");
        }
        public Manager GetDevelopmentTeamManager()
        {
            return _managerRepository.GetAllEmployee().FirstOrDefault(manager => manager.Team.Value == "Development");
        }
        public Manager GetSupportTeamManager()
        {
            return _managerRepository.GetAllEmployee().FirstOrDefault(manager => manager.Team.Value == "Support");
        }
    }
}
