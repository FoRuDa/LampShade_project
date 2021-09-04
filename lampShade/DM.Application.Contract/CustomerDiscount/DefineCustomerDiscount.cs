using System.Collections.Generic;
using ShopManagement.Application.Contract.Product;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class DefineCustomerDiscount
    {

        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public string StartDate { get; set; }
        public string EndTime { get; set; }
        public string Reason { get; set; }

        public List<ProductViewModel> Products { get; set; }

    }

}
