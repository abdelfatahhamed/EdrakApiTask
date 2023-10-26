using EdrakApiTask.DAL;

namespace EdrakApiTask.BL;

public class ProductCustomer : IProductCustomer
{
    private readonly IProductRepository _productRepository;
    private readonly IOrderRepository _OrderRepository;

   public ProductCustomer(IProductRepository productRepository,IOrderRepository OrderRepository)
    {
        _productRepository = productRepository;
        _OrderRepository = OrderRepository;
    }

    public void DeleteProduct(int id)
    {
        var productToDelete = _productRepository.GetById(id);
        if (productToDelete is null)
            throw new NullReferenceException();

        _productRepository.Delete(productToDelete);
        _productRepository.SaveChanges();
    }

    public ProductWithOrderReadDTO? GetProductWithOrder(int id) =>
        _productRepository.GetById(id) is Product product ?
        new ProductWithOrderReadDTO
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Order = _OrderRepository.GetById(product.OrderId)
                is Order cate ? new OrderReadDTO
                {
                    Id = cate.Id,
                    InStock = cate.InStock,
                    Name = cate.Name
                } : null
        } : null;

    public IEnumerable<ProductWithOrderReadDTO> GetProductsWithOrder() =>
        _productRepository.GetAll.Select(
                       p => new ProductWithOrderReadDTO
                       {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Order = _OrderRepository.GetById(p.OrderId)
                is Order cate ? new OrderReadDTO
                {
                    Id = cate.Id,
                    InStock = cate.InStock,
                    Name = cate.Name
                } : null
            }
                                  );

    public IEnumerable<ProductReadDTO> GetProducts() =>
        _productRepository.GetAll.Select(
            p => new ProductReadDTO
            {
                Id = p.Id,
                Description = p.Description,
                Name = p.Name
            }
            );

    public ProductReadDTO? GetProduct(int id) =>
        _productRepository.GetById(id) is Product product ?
        new ProductReadDTO
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description
        } : null;

    public void CreateProduct(ProductCreateDTO productCreateDTO)
    {
        if (productCreateDTO is null)
            throw new NullReferenceException();

        var productToCreate = new Product
        {
            Name = productCreateDTO.Name,
            Description = productCreateDTO.Description,
            OrderId = productCreateDTO.OrderId
        };

        _productRepository.Create(productToCreate);
        _productRepository.SaveChanges();
    }

    public void UpdateProduct(int id, ProductUpdateDTO productUpdateDTO)
    {
        if (productUpdateDTO is null)
            throw new NullReferenceException();

        var productToUpdate = _productRepository.GetById(id);
        if (productToUpdate is null)
            throw new NullReferenceException();

        productToUpdate.Name = productUpdateDTO.Name;
        productToUpdate.Description = productUpdateDTO.Description;
        productToUpdate.OrderId = productUpdateDTO.OrderId;

        _productRepository.Update(productToUpdate);
        _productRepository.SaveChanges();
    }



}
