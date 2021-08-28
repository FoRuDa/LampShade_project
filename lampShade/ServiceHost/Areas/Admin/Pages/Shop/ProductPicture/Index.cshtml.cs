using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Application.Contract.ProductCategory;
using ShopManagement.Application.Contract.ProductPicture;

namespace ServiceHost.Areas.Admin.Pages.Shop.ProductPicture
{
    public class IndexModel : PageModel
    {


        public string Message {get; set; }
        
        
        public ProductPictureSearchModel SearchModel;
        public SelectList Products;
        public List<ProductPictureViewModel> ProductPicture { get; set; }
        private readonly IProductPictureApplication _productPictureApplication;
        private readonly IProductApplication _productApplication;
        public IndexModel(IProductPictureApplication productPictureApplication, IProductApplication productApplication)
        {
            _productPictureApplication = productPictureApplication;
            _productApplication = productApplication;
        }

        public void OnGet(ProductPictureSearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(),"Id","Name");
            ProductPicture = _productPictureApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreatePicture
            {
                Products = _productApplication.GetProducts()
            };

            return Partial("./create",  command);
        }

        public JsonResult OnPost(CreatePicture command)
        {
            var result = _productPictureApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            
            var product = _productPictureApplication.GetDetails(id);
            product.Products = _productApplication.GetProducts();
            return Partial("Edit", product);
        }

        public JsonResult OnPostEdit(EditProductPicture command)
        {
            var result = _productPictureApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
           var result = _productPictureApplication.Remove(id);
           if (result.IsSuccess)
               return RedirectToPage("./index");
           Message = result.Message;
           return RedirectToPage("./index");
        }

        public IActionResult OnGetActive(long id)
        {
            var result = _productPictureApplication.Active(id);
            if (result.IsSuccess)
                return RedirectToPage("./index");
            Message = result.Message;
            return RedirectToPage("./index");
        }
    }
}
