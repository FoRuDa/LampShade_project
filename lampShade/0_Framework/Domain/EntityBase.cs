using System;

namespace _0_Framework.Domain
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }

    }
}
