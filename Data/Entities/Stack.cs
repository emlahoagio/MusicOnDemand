using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Stack
    {
        public Stack()
        {
            Playlists = new HashSet<Playlist>();
        }

        public Guid Id { get; set; }
        public string Status { get; set; }
        public int? Dow { get; set; }
        public Guid? StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
