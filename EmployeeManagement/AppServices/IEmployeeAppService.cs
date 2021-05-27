using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.AppServices
{
    public interface IEmployeeAppService
    {
        Employee AddEmployee(Employee employee);

        List<Employee> GetAllEmployees();

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int Id);

        Employee GetEmployee(int Id);
    }
}
