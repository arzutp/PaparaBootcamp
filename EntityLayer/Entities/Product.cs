using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int ProductFeatureId { get; set; }
        public ProductFeature? ProductFeature { get; set; }

    }
}
