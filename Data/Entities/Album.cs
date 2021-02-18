using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Album
    {
        public Album()
        {
            MediaAlbums = new HashSet<MediaAlbum>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public TimeSpan? Time { get; set; }
        public DateTime? Doi { get; set; }
        public string Producer { get; set; }
        public string Image { get; set; }

        public virtual ICollection<MediaAlbum> MediaAlbums { get; set; }
    }
}
