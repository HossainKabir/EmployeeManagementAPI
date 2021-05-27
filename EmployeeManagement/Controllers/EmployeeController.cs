using EmployeeManagement.AppServices;
using EmployeeManagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeAppService _employeeService;
        public EmployeeController(IEmployeeAppService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("api/Employee/GetAllEmployees")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }

        [HttpPost]
        [Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpPost]
        [Route("api/Employee/UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete]
        [Route("api/Employee/DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok();
            }
            return NotFound($"Employee Not Found with ID : {existingEmployee.Id}");
        }

        [HttpGet]
        [Route("api/Employee/GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
    }
}
