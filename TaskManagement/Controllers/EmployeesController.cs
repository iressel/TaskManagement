using Microsoft.AspNetCore.Mvc;
using TaskManagement.Domain.Dtos;
using TaskManagement.Services.Interfaces;

namespace TaskManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _service;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("GetAllEmployees")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeDto>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAllEmployees()
        {
            var result = await _service.GetAllEmployeesAsync();

            if (result.Any()) return Ok(result);

            _logger.LogInformation("Employees not found");
            return NotFound("Employees not found");
        }
    }
}
