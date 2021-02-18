using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class MediaGenre
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public Guid? MediaId { get; set; }
        public Guid? GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Medium Media { get; set; }
    }
}
