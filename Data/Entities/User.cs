using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class User
    {
        public User()
        {
            Playlists = new HashSet<Playlist>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
