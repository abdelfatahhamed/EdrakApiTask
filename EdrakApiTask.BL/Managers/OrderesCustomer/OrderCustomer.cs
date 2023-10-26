using EdrakApiTask.DAL;

namespace EdrakApiTask.BL;

public class OrderCustomer : IOrderCustomer
{
    private readonly IOrderRepository _OrderRepository;

    public OrderCustomer(IOrderRepository OrderRepository)
    {
        _OrderRepository = OrderRepository;
    }

    public IEnumerable<OrderReadDTO> GetAll =>
        _OrderRepository.GetAll.Select(
            c => new OrderReadDTO
            {
                Id = c.Id,
                Name = c.Name,
                InStock = c.InStock
            }
            );

    public void CreateOrder(OrderCreateDTO OrderDTO)
    {
        if(OrderDTO is null)
            throw new NullReferenceException();

        _OrderRepository.Create(new Order()
        {
            Name = OrderDTO.Name,
            InStock = OrderDTO.InStock
        });
        _OrderRepository.SaveChanges();
    }

    public void DeleteOrder(int id)
    {
        var cat = _OrderRepository.GetById(id);
        if(cat is null)
            throw new NullReferenceException();
        _OrderRepository.Delete( cat );
        _OrderRepository.SaveChanges();
    }

    public OrderReadDTO? GetOrder(int id) =>
        _OrderRepository.GetById(id) is Order Order ?
        new OrderReadDTO
        {
            Id = Order.Id,
            Name = Order.Name,
            InStock = Order.InStock
        } : null;

    public void UpdateOrder(int id, OrderUpdateDTO updateDTO)
    {
        var catToUpdate = _OrderRepository.GetById( id );
        if(catToUpdate is null)
            throw new NullReferenceException();

        catToUpdate.Name = updateDTO.Name;
        catToUpdate.InStock = updateDTO.InStock;
        _OrderRepository.Update( catToUpdate );
        _OrderRepository.SaveChanges();
    }
}
