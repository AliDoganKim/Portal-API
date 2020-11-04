using System;

namespace Portal.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public int CreatedBy { get; set; }

        public short IsActive { get; set; } = 1;

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime? UpdatedTime { get; set; }

        public int? UpdatedBy { get; set; }
    }
}