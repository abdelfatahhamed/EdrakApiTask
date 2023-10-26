namespace EdrakApiTask.DAL;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int InStock { get; set; } 

    ICollection<Product>? Products { get; set;} = new HashSet<Product>();

}
