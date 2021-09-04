using System.Collections.Generic;
using System.Linq;
using _01_LampShadeQuery.Contract.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_LampShadeQuery.Query
{
    public class SlideQuery : ISlideQuery
    {

        private readonly ShopContext _context;

        public SlideQuery(ShopContext context)
        {
            _context = context;
        }

        public List<SlideQueryModel> GetList()
        {
            return _context.Slides.Where(x => x.IsRemove == false).Select(x => new SlideQueryModel
            {
                BtnText = x.BtnText,
                Heading = x.Heading,
                Link = x.Link,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Text = x.Text,
                Title = x.Title


            }).ToList();
        }
    }
}
