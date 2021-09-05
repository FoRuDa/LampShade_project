using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ShopManagement.Application.Contract.Product;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class DefineCustomerDiscount
    {

        [Range(1,100000, ErrorMessage = "آین فیلد اجباری است.")]
        public long ProductId { get; set; }

        [Range(1, 99, ErrorMessage = "آین فیلد اجباری است.")]
        public int DiscountRate { get; set; }

        [Required(ErrorMessage = "آین فیلد اجباری است.")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "آین فیلد اجباری است.")]
        public string EndTime { get; set; }

        public string Reason { get; set; }

        public List<ProductViewModel> Products { get; set; }

    }

}
