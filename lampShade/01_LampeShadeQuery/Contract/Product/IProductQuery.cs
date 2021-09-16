using System.Collections.Generic;

namespace _01_LampShadeQuery.Contract.Product
{
    public interface IProductQuery
    {

        List<ProductQueryModel> GetLatestArrival();
        List<ProductQueryModel> Search(string value);

    }
}
