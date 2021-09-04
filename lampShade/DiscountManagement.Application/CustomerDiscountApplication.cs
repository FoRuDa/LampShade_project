using System;
using System.Collections.Generic;
using _0_Framework.Application;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Domain.CustomerDiscountAgg;

namespace DiscountManagement.Application
{

    
    public class CustomerDiscountApplication :ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountRepository _customerDiscountRepository;

        public CustomerDiscountApplication(ICustomerDiscountRepository customerDiscountRepository)
        {
            _customerDiscountRepository = customerDiscountRepository;
        }

        public OperationResult Define(DefineCustomerDiscount command)
        {
            var operation = new OperationResult();
            if (_customerDiscountRepository.Exists(x => x.ProductId == command.ProductId && x.DiscountRate==command.DiscountRate))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            var customDiscount = new CustomerDiscount(command.ProductId, command.DiscountRate, command.StartDate.ToGeorgianDateTime(),
                command.EndTime.ToGeorgianDateTime(), command.Reason);
            _customerDiscountRepository.Create(customDiscount);
            _customerDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditCustomerDiscount command)
        {
            var operation = new OperationResult();
            var customerDiscount = _customerDiscountRepository.Get(command.Id);
            if (customerDiscount == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            if (_customerDiscountRepository.Exists(x =>
                x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate && x.Id != command.Id))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            customerDiscount.Edit(command.ProductId,
                command.DiscountRate,command.StartDate.ToGeorgianDateTime(),command.EndTime.ToGeorgianDateTime(),command.Reason);
            _customerDiscountRepository.Save();
            return operation.Success();
        }

        public EditCustomerDiscount GetDetails(long id)
        {
            return _customerDiscountRepository.GetDetails(id);
        }

        public List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel searchModel)
        {
            return _customerDiscountRepository.Search(searchModel);
        }
    }
}
