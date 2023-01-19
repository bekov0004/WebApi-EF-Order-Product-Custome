using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    [Timestamp]
    public DateTime OrderPlaced { get; set; }
    [Timestamp] 
    public DateTime Orderfulfilled { get; set; }
    public int CustomerId { get; set; } 
    public Customer Customer { get; set; }
    public OrderDetail OrderDetail { get; set; }

    public Order(int id, DateTime orderPlaced, DateTime orderfulfilled, int customerId)
    {
        Id = id;
        OrderPlaced = orderPlaced;
        Orderfulfilled = orderfulfilled;
        CustomerId = customerId;
    } 
}