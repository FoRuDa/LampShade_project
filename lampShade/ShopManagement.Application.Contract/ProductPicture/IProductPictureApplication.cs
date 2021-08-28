using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contract.ProductPicture
{
    public interface IProductPictureApplication
    {

        OperationResult Create(CreatePicture command);
        OperationResult Edit(EditProductPicture command);
        OperationResult Remove(long id);
        OperationResult Active(long id);
        EditProductPicture GetDetails(long id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);

    }
}
