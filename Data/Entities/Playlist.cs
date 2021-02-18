using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Playlist
    {
        public Playlist()
        {
            PlaylistMedia = new HashSet<PlaylistMedium>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? StackId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Stack Stack { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PlaylistMedium> PlaylistMedia { get; set; }
    }
}
