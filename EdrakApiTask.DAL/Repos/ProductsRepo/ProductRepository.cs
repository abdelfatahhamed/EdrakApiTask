namespace EdrakApiTask.DAL;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly EdrakApiTaskDbContext context;

    public ProductRepository(EdrakApiTaskDbContext context) : base(context)
    {
        this.context = context;
    }
}
