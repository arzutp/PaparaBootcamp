using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category? Category { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User? User { get; set; }
        [JsonIgnore]
        public ProductFeature? ProductFeatures { get; set; }
        [JsonIgnore]
        public ProductDefinition? ProductDefinition { get; set; }

    }
}
