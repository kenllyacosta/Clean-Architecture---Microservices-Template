using Application.Commands.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IMediator Mediator;
        public ProductController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost()]
        public IActionResult Post()
        {
            return Ok(Mediator.Send(new CreateProductCommand(new Domain.Entities.Product() { ProductName = "Azúcar", UnitPrice = 15 })).Result);
        }
    }
}
