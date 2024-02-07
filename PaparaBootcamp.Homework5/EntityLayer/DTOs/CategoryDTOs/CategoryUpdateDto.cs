using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.CategoryDTOs
{
    public class CategoryUpdateDto : CategoryWriteBaseDto
    {
        public int Id { get; set; }
    }
}
