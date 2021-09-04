using System.Collections.Generic;
using DiscountManagement.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contract.Product;

namespace ServiceHost.Areas.Admin.Pages.Discount.CustomerDiscount
{
    public class IndexModel : PageModel
    {


        public string Message {get; set; }
        
        
        public CustomerDiscountSearchModel SearchModel;
        public SelectList Product;
        public List<CustomerDiscountViewModel> CustomerDiscount { get; set; }
        private readonly IProductApplication _productApplication;
        private readonly ICustomerDiscountApplication _customerDiscountApplication;
        public IndexModel(IProductApplication productApplication, ICustomerDiscountApplication customerDiscountApplication)
        {
            _productApplication = productApplication;
            _customerDiscountApplication = customerDiscountApplication;
        }

        public void OnGet(CustomerDiscountSearchModel searchModel)
        {
            Product =new SelectList(_productApplication.GetProducts(),"Id","Name");
            CustomerDiscount = _customerDiscountApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new DefineCustomerDiscount
            {
                Products = _productApplication.GetProducts()
            };

                return Partial("./create",command);
        }

        public JsonResult OnPost(DefineCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Define(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            
            var customerDiscount = _customerDiscountApplication.GetDetails(id);
            customerDiscount.Products= _productApplication.GetProducts();
            return Partial("Edit", customerDiscount);
        }

        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
