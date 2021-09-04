﻿using System.Collections.Generic;
using System.Net;
using System.Net.WebSockets;
using _0_Framework.Application;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;

namespace DiscountManagement.Application
{
    public class ColleagueDiscountApplication : IColleagueDiscountApplication
    {
        private readonly IColleagueDiscountRepository _colleagueDiscountRepository;

        public ColleagueDiscountApplication(IColleagueDiscountRepository colleagueDiscountRepository)
        {
            _colleagueDiscountRepository = colleagueDiscountRepository;
        }

        public OperationResult Define(DefineColleagueDiscount command)
        {
            var operation = new OperationResult();
            if (_colleagueDiscountRepository.Exists(x =>
                x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            var colleague = new ColleagueDiscount(command.ProductId, command.DiscountRate);
            _colleagueDiscountRepository.Create(colleague);
            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditColleagueDiscount command)
        {
            var operation = new OperationResult();
            var colleagueDiscount = _colleagueDiscountRepository.Get(command.Id);
            if (colleagueDiscount == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            if (_colleagueDiscountRepository.Exists(x =>
                x.ProductId == command.ProductId && x.DiscountRate == command.DiscountRate && x.Id != command.Id))
                return operation.Faild(ApplicationMessages.DuplicatedRecord);
            colleagueDiscount.Edit(command.Id,command.DiscountRate);
            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var colleague = _colleagueDiscountRepository.Get(id);
            if (colleague == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            colleague.Remove();
            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public OperationResult Active(long id)
        {
            var operation = new OperationResult();
            var colleague = _colleagueDiscountRepository.Get(id);
            if (colleague == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            colleague.Restore();
            _colleagueDiscountRepository.Save();
            return operation.Success();
        }

        public EditColleagueDiscount GetDetails(long id)
        {
            return _colleagueDiscountRepository.GetDetails(id);
        }

        public List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel)
        {
            return _colleagueDiscountRepository.Search(searchModel);
        }
    }
}
