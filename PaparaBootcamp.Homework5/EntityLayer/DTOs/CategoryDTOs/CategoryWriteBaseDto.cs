using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.CategoryDTOs
{
    public class CategoryWriteBaseDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
