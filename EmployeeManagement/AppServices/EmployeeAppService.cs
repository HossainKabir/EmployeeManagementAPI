using EmployeeManagement.ApplicationDbContexts;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AppServices
{
    public class EmployeeAppService : IEmployeeAppService
    {
        public ApplicationDbContext _dbContext;

        public EmployeeAppService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int Id)
        {
            var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee != null)
            {
                _dbContext.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee GetEmployee(int Id)
        {
            return _dbContext.Employees.FirstOrDefault(x => x.Id == Id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
        }
    }
}
