using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class MediaAlbum
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public Guid? MediaId { get; set; }
        public Guid? AlbumId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Medium Media { get; set; }
    }
}
