using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class OrderServices
{
    private readonly DataContext _context;

    public OrderServices(DataContext context)
    {
        _context = context;
    }

    public List<OrderDto> GetOrder()
    {
        return _context.Orders.Select(x => new OrderDto()
        {
            Id = x.Id,
            CustomerId = x.CustomerId,
            OrderDate = x.OrderPlaced,
            FullName = string.Concat(x.Customer.FirstName," ",x.Customer.LastName),
            Address = x.Customer.Address,
            ProductName = x.OrderDetail.Product.Name 
        }).ToList();
    }
    
    public List<OrderDto> GetOrdersByDate(DateTime date)
    {
        
        return _context.Orders
            .Where(x=>x.OrderPlaced.Date == date.Date)
            .Select(x => new OrderDto()
            {
                Address = x.Customer.Address,
                Id = x.Id,
                OrderDate = x.OrderPlaced,
                CustomerId = x.CustomerId,
                FullName = string.Concat(x.Customer.FirstName, " ", x.Customer.LastName),
                ProductName = x.OrderDetail.Product.Name
            }).ToList();
    }
    public Order? GetpOrderById(int id)
    {
        return _context.Orders.FirstOrDefault(x => x.Id == id);
    }

    public void AddOrder(AddOrderDto order)
    {
        var mapped = new Order(order.Id,order.OrderPlaced,order.Orderfulfilled,order.CustomerId);
        _context.Orders.Add(mapped);
        _context.SaveChanges();
    }
    
    public void DeleteOrder(int id)
    {
        var delete = _context.Orders.First(c => c.Id == id);
        _context.Orders.Remove(delete);
        _context.SaveChanges();
    }
    
    

}