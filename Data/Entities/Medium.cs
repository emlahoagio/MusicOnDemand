using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Medium
    {
        public Medium()
        {
            MediaAlbums = new HashSet<MediaAlbum>();
            MediaGenres = new HashSet<MediaGenre>();
            MediaSingers = new HashSet<MediaSinger>();
            PlaylistMedia = new HashSet<PlaylistMedium>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? Doi { get; set; }
        public string Musician { get; set; }

        public virtual ICollection<MediaAlbum> MediaAlbums { get; set; }
        public virtual ICollection<MediaGenre> MediaGenres { get; set; }
        public virtual ICollection<MediaSinger> MediaSingers { get; set; }
        public virtual ICollection<PlaylistMedium> PlaylistMedia { get; set; }
    }
}
