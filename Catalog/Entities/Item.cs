using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; } // sadece init'de değer alır. yaratıldıktan sonra değer alamaz.
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

    }
}
