# Microservice with Ocelot 

## About Ocelot 

More about [Ocelot](https://ocelot.readthedocs.io/en/latest/introduction/bigpicture.html)

## About The Project

This is an example of how you may setting ocelot in your project.

##  Prerequisites
    .NET 7

### Overview 

Run all projects and access endpoints 

* products - https://localhost:5000/gateway/products
* customers - https://localhost:5000/gateway/customers


Projects
- Gateway API
    * Redirect from gateway/products to api/products 
    * Redirect from gateway/customers to api/customers 


- Product API
    * Return a mock list of products

- Customer API
    * Return a mock list of customers


