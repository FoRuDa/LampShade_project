using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contract.Product
{
    public interface IProductApplication
    {
        List<ProductViewModel> GetProducts();
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
        EditProduct GetDetails(long id);
        List<ProductViewModel> Search(ProductSearchModel searchModel);
        OperationResult InStock(long id);
        OperationResult NotInStock(long id);
        
    }
}
