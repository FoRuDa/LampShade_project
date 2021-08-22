using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagement.Application.Contract.ProductCategory;

using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_productCategoryRepository.Exists(x=>x.Name == command.Name) == true)
                return operation.Faild("نام تکرراری است لطفا دوباره تلاش کنید.");
            var slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.Name, command.Description, command.Picture,
                command.PictureAlt,
                command.PictureTitle, command.Keywords, command.MetaDescription, slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory == null)
                return operation.Faild("رکورد خالی است.");
            if (_productCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Faild("امکان ثبت رکورد تکراری وجود ندارد.");
            var slug = command.Slug.Slugify();
            productCategory.Edit(command.Name,command.Description,command.Picture,
                command.PictureAlt,command.PictureTitle,command.Keywords,command.MetaDescription,slug);
            _productCategoryRepository.Save();
            return operation.Success();
        }

        public EditProductCategory GetDetail(long id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> SearchModel(ProductCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
