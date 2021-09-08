using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using ShopManagement.Application.Contract.Product;
using ShopManagement.Application.Contract.ProductCategory;

namespace ServiceHost.Areas.Admin.Pages.Shop.Products
{
    public class IndexModel : PageModel
    {


        public string Message {get; set; }
        
        
        public ProductSearchModel search;
        public SelectList ProductCategories;
        public List<ProductViewModel> Products { get; set; }
        private readonly IProductApplication _productApplication;
        private readonly IProductCategoryApplication _productCategoryApplication;
        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productCategoryApplication)
        {
            _productApplication = productApplication;
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(ProductSearchModel search)
        {
            ProductCategories =new SelectList(_productCategoryApplication.GetProductCategories(),"Id","Name");
            Products = _productApplication.Search(search);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Categories = _productCategoryApplication.GetProductCategories()
            };

            return Partial("./create",  command);
        }

        public JsonResult OnPost(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            
            var product = _productApplication.GetDetails(id);
            product.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }

        //public IActionResult OnGetNotInStock(long id)
        //{
        //   var result = _productApplication.NotInStock(id);
        //   if (result.IsSuccess)
        //       return RedirectToPage("./index");
        //   Message = result.Message;
        //   return RedirectToPage("./index");
        //}

        //public IActionResult OnGetIsInStock(long id)
        //{
        //    var result = _productApplication.InStock(id);
        //    if (result.IsSuccess)
        //        return RedirectToPage("./index");
        //    Message = result.Message;
        //    return RedirectToPage("./index");
        //}
    }
}
