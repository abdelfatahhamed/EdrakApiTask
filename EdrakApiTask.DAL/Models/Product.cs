using EdrakApiTask.BL.Customers;

namespace EdrakApiTask.DAL;

public class Product
{
    public  int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; } 

    public int OrderId { get; set; }

    public Order? Order { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

}
