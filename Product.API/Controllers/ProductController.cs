using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Product
        {
            Id = Guid.NewGuid(),
            Name = $"Product {index}"
        })
        .ToArray();
    }
}


public class Product
{

    public Guid Id { get; set; }

    public string? Name { get; set; }
}


