using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ShopManagement.Application.Contract.Product;

namespace ShopManagement.Application.Contract.ProductPicture
{
    public class CreatePicture
    {
        [Range(1,100000 ,ErrorMessage = "این رکورد باید پر شود.")]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "این رکورد باید پر شود.")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "این رکورد باید پر شود.")]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = "این رکورد باید پر شود.")]
        public string PictureTitle { get; set; }
        public List<ProductViewModel> Products { set; get; }

    }
}
