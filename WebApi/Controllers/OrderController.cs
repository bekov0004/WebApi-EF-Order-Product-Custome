using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class OrderController
{
    private OrderServices _orderServices;

    public OrderController(OrderServices orderServices)
    {
        _orderServices = orderServices;
    }

    [HttpGet("GetOrder")]
    public List<OrderDto> GetOrder()
    {
       return _orderServices.GetOrder();
    }
    [HttpGet("GetOrdersByDate")]
    public List<OrderDto> GetOrdersByDate(DateTime date)
    {
        return _orderServices.GetOrdersByDate(date);
    }

    [HttpGet("GetOrderById")]
    public Order GetOrderById(int id)
    {
      return _orderServices.GetpOrderById(id);
    }

    [HttpPost("AddOrder")]
    public void AddOrder(AddOrderDto order)
    {
        _orderServices.AddOrder(order);
    }
    [HttpDelete("Delete")]
    public void DeleteOrder(int id)
    {
        _orderServices.DeleteOrder(id);
    }
}