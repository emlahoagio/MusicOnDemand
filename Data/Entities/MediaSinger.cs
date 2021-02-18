using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class MediaSinger
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string MainSinger { get; set; }
        public Guid? MediaId { get; set; }
        public Guid? SingerId { get; set; }

        public virtual Medium Media { get; set; }
        public virtual Singer Singer { get; set; }
    }
}
