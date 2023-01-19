using Domain.Entities;

namespace Domain.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ProductName { get; set; }

    public OrderDto()
    {
        
    }
 
}