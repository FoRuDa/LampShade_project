﻿using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Domain.ProductPictureAgg
{
    public class ProductPicture : EntityBase<long>
    {
        public long ProductId { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsDeleted { get; private set; }
        public Product Product { get; private set; }
        public ProductPicture(long productId, string picture, string pictureAlt, string pictureTitle)
        {
            ProductId = productId;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            IsDeleted = false;
        }

        public void Edit(long productId, string picture, string pictureAlt, string pictureTitle)
        {
            ProductId = productId;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
        }

        public void Deleted()
        {
            IsDeleted = true;
        }

        public void Active()
        {
            IsDeleted = false;
        }
    }
}
