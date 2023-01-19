using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerControoller
{
    private CustomerServices _customerServices;

    public CustomerControoller(CustomerServices customerServices)
    {
        _customerServices = customerServices;
    }
    
    [HttpGet("GetCustomer")]
    public List<CustomerDto> GetCustomer()
    {
        return _customerServices.GetCustomer();
    }
    [HttpGet("GetCustomerByName")]
    public List<CustomerDto> GetCustomerByName(string name)
    {
        return _customerServices.GetCompanyByName(name);
    }
    [HttpPost("AddCustomer")]
    public bool AddCustomer(CustomerDto customer)
    {
        _customerServices.AddCustomer(customer);
        return true;
    }
    [HttpPut("UpdateCustomer")]
    public bool UpdateCustomer(CustomerDto customer)
    {
        _customerServices.UpdateCustomer(customer);
        return true;
    }

    [HttpDelete("Delete")]
    public void DeleteCustomer(int id)
    {
        _customerServices.DeleteCustomer(id);
    }
    
}