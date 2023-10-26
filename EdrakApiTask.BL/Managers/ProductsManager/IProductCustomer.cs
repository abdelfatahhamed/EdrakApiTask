using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrakApiTask.BL;

public interface IProductCustomer
{
    IEnumerable<ProductWithOrderReadDTO> GetProductsWithOrder();

    IEnumerable<ProductReadDTO> GetProducts();

    ProductReadDTO? GetProduct(int id);

    ProductWithOrderReadDTO? GetProductWithOrder(int id);

    void DeleteProduct(int id);

    void CreateProduct (ProductCreateDTO productCreateDTO);

    void UpdateProduct(int id, ProductUpdateDTO productUpdateDTO);


}
