using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.ProductDTOs
{
    public class ProductUpdateDto : ProductWriteBaseDto
    {
        public int Id { get; set; }
    }
}
