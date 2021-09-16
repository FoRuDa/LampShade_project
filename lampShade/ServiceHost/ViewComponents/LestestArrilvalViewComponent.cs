using _01_LampShadeQuery.Contract.Product;
using _01_LampShadeQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{

    public class LatestArrivalViewComponent : ViewComponent
    {
        private readonly IProductQuery _productQuery;

        public LatestArrivalViewComponent( IProductQuery productQuery)
        {
            _productQuery = productQuery;
           
        }

        public IViewComponentResult Invoke()
        {
            var products = _productQuery.GetLatestArrival();
            return View(products);
        }
    }
}
