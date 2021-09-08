using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using ShopManagement.Application.Contract.Product;

namespace InventoryManagement.Application.Contract.Inventory
{
    public class CreateInventory
    {

        [Range(1,100000,ErrorMessage = "مقدار را وارد کنید.")]
        public long ProductId { get; set; }

        [Range(1,double.MaxValue,ErrorMessage = "مقدار را وارد کنید")]
        public double UnitPrice { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
