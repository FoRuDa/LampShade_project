using System;
using _0_Framework.Domain;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public class CustomerDiscount : EntityBase<long>
    {

        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndTime { get; private set; }
        public string Reason { get; private set; }

        public CustomerDiscount(long productId, int discountRate, DateTime startDate, DateTime endTime, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndTime = endTime;
            Reason = reason;
        }

        public void Edit(long productId, int discountRate, DateTime startDate, DateTime endTime, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndTime = endTime;
            Reason = reason;
        }
    }
}
