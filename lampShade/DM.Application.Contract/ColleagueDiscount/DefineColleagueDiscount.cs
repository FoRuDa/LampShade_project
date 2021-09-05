using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using ShopManagement.Application.Contract.Product;

namespace DiscountManagement.Application.Contract.ColleagueDiscount
{
    public class DefineColleagueDiscount
    {


        [Range(1,100000,ErrorMessage = "این فیلد اجباری است.")]
        public long ProductId { get; set; }

        [Range(1, 99, ErrorMessage = "این فیلد اجباری است.")]
        public int DiscountRate { get; set; }
        public List<ProductViewModel> Products { get; set; }

    }
}
