using System.Collections.Generic;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Application.Contract.CustomerDiscount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contract.Product;

namespace ServiceHost.Areas.Admin.Pages.Discount.ColleagueDIscount
{
    public class IndexModel : PageModel
    {


        public string Message {get; set; }
        
        
        public ColleagueDiscountSearchModel SearchModel;
        public SelectList Product;
        public List<ColleagueDiscountViewModel> ColleagueDiscount { get; set; }
        private readonly IProductApplication _productApplication;
        private readonly IColleagueDiscountApplication _colleagueDiscountApplication;
        public IndexModel(IProductApplication productApplication, IColleagueDiscountApplication colleagueDiscountApplication)
        {
            _productApplication = productApplication;
            _colleagueDiscountApplication = colleagueDiscountApplication;
        }

        public void OnGet(ColleagueDiscountSearchModel searchModel)
        {
            Product =new SelectList(_productApplication.GetProducts(),"Id","Name");
            ColleagueDiscount = _colleagueDiscountApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new DefineColleagueDiscount
            {
                Products = _productApplication.GetProducts()
            };

                return Partial("./create",command);
        }

        public JsonResult OnPost(DefineColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Define(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            
            var colleagueDiscount = _colleagueDiscountApplication.GetDetails(id);
            colleagueDiscount.Products = _productApplication.GetProducts();
            return Partial("Edit", ColleagueDiscount);
        }

        public JsonResult OnPostEdit(EditColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Edit(command);
            return new JsonResult(result);
        }

        public RedirectToPageResult OnGetRemove(long id)
        {
            var result = _colleagueDiscountApplication.Remove(id);
                if (result.IsSuccess)
                    return RedirectToPage("./index");
                Message = result.Message;
                return RedirectToPage("./index");
            }

        public RedirectToPageResult OnGetRestore(long id)
        {
            var result = _colleagueDiscountApplication.Active(id);
            if (result.IsSuccess) 
                return RedirectToPage("./index");
            Message = result.Message;
            return RedirectToPage("./index");
        }

        }


    

}
