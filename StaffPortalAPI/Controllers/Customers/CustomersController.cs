using MediatR;
using Microsoft.AspNetCore.Mvc;
using StaffPortalAPI.Application.Customers.Create;
using StaffPortalAPI.Domain.Models.Customers;

namespace StaffPortalAPI.Web.Controllers.Customers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}
