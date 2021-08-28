using System.Collections.Generic;
using System.Runtime.InteropServices;
using _0_Framework.Application;
using ShopManagement.Application.Contract.ProductPicture;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManagement.Application
{
    public class ProductPictureApplication : IProductPictureApplication
    {
        private readonly IProductPictureRepository _productPictureRepository;

        public ProductPictureApplication(IProductPictureRepository productPictureRepository)
        {
            _productPictureRepository = productPictureRepository;
        }

        public OperationResult Create(CreatePicture command)
        {
            var operation = new OperationResult();
            if (_productPictureRepository.Exists(x=>x.Picture == command.Picture && x.ProductId!=command.ProductId))
            {
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            }

            var productPicture = new ProductPicture(command.ProductId, command.Picture, command.PictureAlt,
                command.PictureTitle);
            _productPictureRepository.Create(productPicture);
            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(command.Id);
            if (productPicture==null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            if (_productPictureRepository.Exists(x => x.Picture == command.Picture &&
                                                      x.ProductId != command.ProductId && x.Id != command.Id))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            productPicture.Edit(command.ProductId,command.Picture,command.PictureAlt,command.PictureTitle);
            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);

            productPicture.Deleted();

            _productPictureRepository.Save();
            return operation.Success();
        }

        public OperationResult Active(long id)
        {
            var operation = new OperationResult();
            var productPicture = _productPictureRepository.Get(id);
            if (productPicture == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);

            productPicture.Active();

            _productPictureRepository.Save();
            return operation.Success();
        }

        public EditProductPicture GetDetails(long id)
        {
            return _productPictureRepository.GetDetails(id);
        }

        public List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel)
        {
            return _productPictureRepository.Search(searchModel);
        }
    }
}
