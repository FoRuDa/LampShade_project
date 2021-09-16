using System.Collections.Generic;

namespace _01_LampShadeQuery.Contract.ProductCategory
{
    public interface IProductCategoryQuery
    {

        ProductCategoryQueryModel GeyProductCategoryWithProductBy(string slug);
        List<ProductCategoryQueryModel> GetList();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();

    }
}