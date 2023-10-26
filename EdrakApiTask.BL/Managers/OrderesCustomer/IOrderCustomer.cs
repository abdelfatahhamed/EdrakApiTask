using EdrakApiTask.DAL;

namespace EdrakApiTask.BL;

public interface IOrderCustomer
{
    IEnumerable<OrderReadDTO> GetAll { get; }
    OrderReadDTO? GetOrder(int id);

    void CreateOrder(OrderCreateDTO OrderDTO);
    void UpdateOrder(int id , OrderUpdateDTO updateDTO); 

    void DeleteOrder(int id);


}
