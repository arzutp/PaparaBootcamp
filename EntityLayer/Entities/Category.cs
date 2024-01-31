using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; }= default!;
        public List<Product>? Products { get; set; }

    }
}
