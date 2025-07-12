using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string> { "Alice", "Bob", "Charlie" };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");
            return Ok(employees[id]);
        }

        [HttpPost]
        public IActionResult Create([FromBody] string name)
        {
            employees.Add(name);
            return Ok($"Employee '{name}' added.");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string name)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            employees[id] = name;
            return Ok($"Employee at index {id} updated to '{name}'.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound("Employee not found");

            string deleted = employees[id];
            employees.RemoveAt(id);
            return Ok($"Employee '{deleted}' removed.");
        }
    }
}
