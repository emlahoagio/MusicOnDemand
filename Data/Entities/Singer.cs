using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Singer
    {
        public Singer()
        {
            MediaSingers = new HashSet<MediaSinger>();
        }

        public Guid Id { get; set; }
        public string StageName { get; set; }
        public string Status { get; set; }
        public DateTime? Dob { get; set; }
        public string Origin { get; set; }
        public string BirthName { get; set; }
        public string Image { get; set; }

        public virtual ICollection<MediaSinger> MediaSingers { get; set; }
    }
}
