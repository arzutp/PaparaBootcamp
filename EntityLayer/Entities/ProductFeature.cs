using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ProductFeature : BaseEntity
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; } = default!;
        public int ProductId { get; set; }
    }
}
