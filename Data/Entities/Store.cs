using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Store
    {
        public Store()
        {
            Stacks = new HashSet<Stack>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public TimeSpan? Open { get; set; }
        public TimeSpan? Close { get; set; }
        public Guid? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Stack> Stacks { get; set; }
    }
}
