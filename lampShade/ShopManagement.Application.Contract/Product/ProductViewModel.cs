using System;

namespace ShopManagement.Application.Contract.Product
{

    //Show for admin نمایش برای مدیر
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Picture { get; set; }
        public double UnitPrice { get; set; }
        public string Category { get; set; }
        public bool IsInStock { get; set; }
        public long categoryId { get; set; }
        public string CreationDate { get; set; }
    }
}