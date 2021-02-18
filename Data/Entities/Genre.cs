using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            MediaGenres = new HashSet<MediaGenre>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<MediaGenre> MediaGenres { get; set; }
    }
}
