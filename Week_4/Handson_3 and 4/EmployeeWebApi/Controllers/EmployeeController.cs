using Microsoft.AspNetCore.Mvc;
using EmployeeWebApi.Models;
using EmployeeWebApi.Filters;

namespace EmployeeWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter] // 🔐 Authorization filter
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees;

        public EmployeeController()
        {
            if (_employees == null || !_employees.Any())
            {
                _employees = GetStandardEmployeeList();
            }
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1990, 5, 21)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "C#" },
                        new Skill { Id = 4, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1988, 11, 3)
                }
            };
        }

        // ❗ GET: api/employee (throws exception to test filter)
        [HttpGet]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [ProducesResponseType(500)]
        public ActionResult<List<Employee>> Get()
        {
            throw new Exception("This is a test exception");
        }

        // ✅ GET: api/employee/standard
        [HttpGet("standard")]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(_employees.First());
        }

        // ✅ POST: api/employee
        [HttpPost]
        [ProducesResponseType(typeof(Employee), 201)]
        public IActionResult Create([FromBody] Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
            return CreatedAtAction(nameof(GetStandard), new { id = employee.Id }, employee);
        }

        // ✅ PUT: api/employee/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(400)]
        public ActionResult<Employee> Update(int id, [FromBody] Employee updatedEmployee)
        {
            // Validate ID
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmployee = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
                return BadRequest("Invalid employee id");

            // Update fields
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Salary = updatedEmployee.Salary;
            existingEmployee.Permanent = updatedEmployee.Permanent;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Skills = updatedEmployee.Skills;
            existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;

            return Ok(existingEmployee); // Return updated employee
        }
    }
}
