using MediatR;
using Microsoft.AspNetCore.Mvc;
using StaffPortalAPI.Application.Products.Create;
using StaffPortalAPI.Application.Products.Queries;
using StaffPortalAPI.Domain.Models.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StaffPortalAPI.Web.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _mediator.Send(request: new GetProductListQuery());
            return Ok(products);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Product>> Get(Guid id, ISender sender)
        {
            return Ok(await sender.Send(new GetProductQuery(new ProductId(id))));
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]


        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
