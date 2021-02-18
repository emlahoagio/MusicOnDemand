using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Playlists = new HashSet<Playlist>();
            Stores = new HashSet<Store>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
