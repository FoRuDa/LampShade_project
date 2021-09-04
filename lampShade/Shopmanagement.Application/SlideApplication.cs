using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contract.Slide;
using ShopManagement.Domain.SlideAgg;

namespace ShopManagement.Application
{
    public class SlideApplication : ISlideApplication
    {
        private readonly ISlideRepository _slideRepository;

        public SlideApplication(ISlideRepository slideRepository)
        {
            _slideRepository = slideRepository;
        }

        public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();
            var slider = new Slide(command.Picture, command.PictureAlt, command.PictureTitle, command.Heading,
                command.Title, command.Text, command.BtnText, command.Link);

            _slideRepository.Create(slider);
            _slideRepository.Save();
            return operation.Success();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation = new OperationResult();
            var query = _slideRepository.Get(command.Id);
            if (query == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            query.Edit(command.Picture, command.PictureAlt, command.PictureTitle, command.Heading, command.Title,
                command.Text, command.BtnText,command.Link);
            _slideRepository.Save();
            return operation.Success();
        }

        public List<SlideViewModel> GetList()
        {
            return _slideRepository.GetList();
        }

        public EditSlide GetDetails(long id)
        {
            return _slideRepository.GetDetails(id);
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var query = _slideRepository.Get(id);
            if (query == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            query.Remove();
            _slideRepository.Save();
            return operation.Success();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var query = _slideRepository.Get(id);
            if (query == null)
                return operation.Faild(ApplicationMessages.RecordNotFound);
            query.Restore();
            _slideRepository.Save();
            return operation.Success();
        }
    }
}
