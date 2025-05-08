using BusinessApp.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BusinessApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeCommand command)
    {
        var id = await mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, id);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        // Placeholder: to be implemented
        return Ok();
    }
}
