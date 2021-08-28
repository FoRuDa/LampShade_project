using System.Collections.Generic;
using System.Runtime.InteropServices;
using _0_Framework.Application;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();
            if (_productRepository.Exists(x=>x.Name == command.Name))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            var slug = command.Slug.Slugify();

            var product = new Product(command.Name, command.Code, command.UnitPrice, command.ShortDescription,
                command.ShortDescription
                , command.Picture, command.PictureAlt, command.PictureTitle, command.CategoryId, slug, command.Keywords,
                command.MetaDescription);

             _productRepository.Create(product);
             _productRepository.Save();
             return operation.Success();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);
            if (product == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            if (_productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            //----------------------------------
            var slug = command.Slug.Slugify();
            product.Edit(command.Name, command.Code, command.UnitPrice, command.ShortDescription,
                command.ShortDescription
                , command.Picture, command.PictureAlt, command.PictureTitle, command.CategoryId, slug, command.Keywords,
                command.MetaDescription);
            
            _productRepository.Save();
            return operation.Success();

        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }

        public OperationResult InStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);

           
            //----------------------------------
           
            product.InStock();

            _productRepository.Save();
            return operation.Success();
        }

        public OperationResult NotInStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);
            if (product == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);


            //----------------------------------

            product.NotInStock();

            _productRepository.Save();
            return operation.Success();
        }
    }
}
