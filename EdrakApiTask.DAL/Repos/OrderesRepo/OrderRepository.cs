namespace EdrakApiTask.DAL;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    private readonly EdrakApiTaskDbContext context;

    public OrderRepository(EdrakApiTaskDbContext context) : base(context)
    {
        this.context = context;
    }
}
