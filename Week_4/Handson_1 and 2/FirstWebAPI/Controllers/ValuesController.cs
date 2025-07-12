using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/emp")] // Changed from [controller] to 'emp'
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [HttpGet("{id}")]
        [ActionName("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            return Ok("value" + id);
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Received: " + value);
        }

        [HttpPut("{id}")]
        [ActionName("Update")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok($"Updated {id} with {value}");
        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted {id}");
        }
    }
}
