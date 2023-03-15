using Application.Handler;
using Application.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetAllEmployee")]
        public async Task<ActionResult<List<EmployeeReadModel>>> Get()
        {
            var employee = await _mediator.Send(new GetAllEmployeeQuery());

            return Ok(employee);
        }

        [HttpPost("CreateEmployee")]
        public async Task<ActionResult> Post([FromBody] EmployeeCreateModel model)
        {
            await _mediator.Send(new CreateEmployeeCommand(model.FirstName, model.LastName, model.DateOfBirth));
            return Ok();
        }
    }
}
