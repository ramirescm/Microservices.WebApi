using System;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{

    [HttpGet]
    public IEnumerable<Customer> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Customer
        {
            Id = Guid.NewGuid(),
            Name = $"Customer {index}"
        })
        .ToArray();
    }
}


public class Customer
{

    public Guid Id { get; set; }

    public string? Name { get; set; }
}

