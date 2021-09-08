using System.Collections.Generic;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using InventoryManagement.Application.Contract.Inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contract.Product;

namespace ServiceHost.Areas.Admin.Pages.Inventory
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message {get; set; }
        
        
        public InventorySearchModel SearchModel;
        public SelectList Product;
        public List<InventoryViewModel> Inventory { get; set; }
        private readonly IProductApplication _productApplication;
        private readonly IInventoryApplication _inventoryApplication;
        public IndexModel(IProductApplication productApplication, IInventoryApplication inventoryApplication)
        {
            _productApplication = productApplication;
            _inventoryApplication = inventoryApplication;
          
        }

        public void OnGet(InventorySearchModel searchModel)
        {
            Product =new SelectList(_productApplication.GetProducts(),"Id","Name");
            Inventory = _inventoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateInventory
            {
                Products = _productApplication.GetProducts()
            };

                return Partial("./create",command);
        }

        public JsonResult OnPost(CreateInventory command)
        {
            var result = _inventoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            
            var inventory = _inventoryApplication.GetDetails(id);
            inventory.Products = _productApplication.GetProducts();
            return Partial("Edit", inventory);
        }

        public JsonResult OnPostEdit(EditInventory command)
        {
            var result = _inventoryApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetIncrease(long id)
        {

            var command = new IncreaseInventory()
            {
                InventoryId = id
            };
            
            return Partial("increase",command );
        }

        public JsonResult OnPostIncrease(IncreaseInventory command)
        {
            var result = _inventoryApplication.Increase(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetReduce(long id)
        {

            var command = new DecreaseInventory()
            {
                InventoryId = id
            };

            return Partial("Reduce", command);
        }

        public JsonResult OnPostReduce(DecreaseInventory command)
        {
            var result = _inventoryApplication.Reduce(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetLog(long id)
        {

            var log= _inventoryApplication.GetOprrationLog(id);
            return Partial("OperationLog", log);
        }
    }


    

}
