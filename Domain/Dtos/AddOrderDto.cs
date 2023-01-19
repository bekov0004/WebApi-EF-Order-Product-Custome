using Domain.Entities;

namespace Domain.Dtos;

public class AddOrderDto
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime Orderfulfilled { get; set; }
    public int CustomerId { get; set; }

    public AddOrderDto()
    {
        
    }
    
}