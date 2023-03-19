# Microservice with Ocelot Gateway API NET 7.0

### Ocelot 

```https://ocelot.readthedocs.io/en/latest/index.html```


### Run

Run all projects and access endpoints 

    products - https:]//localhost:5000/gateway/products
    customers https://localhost:5000/gateway/customers

- Gateway API
    Ocelot gateway api
    
    Receive request on gateway/products and redirect to api/products 
    Receive request on gateway/products and redirect to api/customers


- Product API
    Return a mock list of products

- Customer API
    Return a mock list of customers