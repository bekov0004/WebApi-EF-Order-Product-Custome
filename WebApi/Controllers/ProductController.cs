using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductController
{
    private ProductServices _productServices;

    public ProductController(ProductServices productServices)
    {
        _productServices = productServices;
    }
    
    [HttpGet("GetProduct")]
    public List<ProductDto> GetProduct()
    {
        return _productServices.GetProduct();
    }
    [HttpGet("GetProductByName")]
    public List<ProductDto> GetProductByName(string name)
    {
        return _productServices.GetPoductByName(name);
    }

    [HttpGet("GetProductById")]
    public Product GetProductById(int id)
    {
      return  _productServices.GetpProductById(id);
    }
    [HttpPost("AddProduct")]
    public bool AddProduct(ProductDto product)
    {
        _productServices.AddProduct(product);
        return true;
    }
    [HttpPut("UpdateProduct")]
    public bool UpdateProduct(ProductDto product)
    {
        _productServices.UpdateProduct(product);
        return true;
    }

    [HttpDelete("Delete")]
    public void DeleteProduct(int id)
    {
        _productServices.DeleteProduct(id);
    }
}