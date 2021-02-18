using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class PlaylistMedium
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public Guid? PlaylistId { get; set; }
        public Guid? MediaId { get; set; }

        public virtual Medium Media { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}
