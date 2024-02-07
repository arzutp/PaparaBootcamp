using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.ProductFeatureDTOs
{
    public class ProductFeatureReadBaseDto 
    {
        public int Id { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; } = default!;
        public int ProductId { get; set; }
    }
}
