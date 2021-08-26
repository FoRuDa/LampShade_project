using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using _0_Framework.Domain;
using ShopManagement.Application.Contract.ProductCategory;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long, ProductCategory>

    {

    List<ProductCategoryViewModel> GetProductCategories();
    EditProductCategory GetDetail(long id);
    List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    
    }
}
