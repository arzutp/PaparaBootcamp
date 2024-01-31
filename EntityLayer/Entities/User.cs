using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = default!;
        public string Product { get; set; } = default!;
        public string Email { get; set; } = default!;
        public List<Product>? Products { get; set; }
    }
}
