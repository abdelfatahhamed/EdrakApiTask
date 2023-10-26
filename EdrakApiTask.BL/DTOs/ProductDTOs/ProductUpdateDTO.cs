namespace EdrakApiTask.BL;

public class ProductUpdateDTO
{
    public required string Name { get; set; } = string.Empty;
    public required string Description { get; set; } = string.Empty;
    public required int OrderId { get; set; }

}
