using Microsoft.AspNetCore.Mvc;
using Domain.DtosProducts;
using Infrastructure;

[ApiController]
[Route("[controller]")]

public class ProductController
{
    private ProductService _productService;
    public ProductController()
    {
        _productService = new ProductService();
    }

    [HttpGet]
    public List<Product> GetProducts()
    {
        return _productService.GetProducts();
    }
    
    [HttpPut]
    public int InsertProduct(Product product)
    {
        return _productService.InsertProduct(product);
    }

    [HttpGet("Get by Join")]
    public List<Product> GetByJoin()
    {
        return _productService.GetByJoin();
    }

    [HttpGet("Get products with total amount of orders")]
    public List<Product> GetProductsWithAmountOrder()
    {
        return _productService.GetProductsWithAmountOrder();
    }

    [HttpGet("Get Products with manufacturer")]
    public List<Product> GetProductsWithManufacturer()
    {
        return _productService.GetProductsWithManufacturer();
    }
}
