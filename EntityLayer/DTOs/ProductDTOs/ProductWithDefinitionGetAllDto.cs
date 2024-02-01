using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.ProductDTOs
{
    public class ProductWithDefinitionGetAllDto : ProductReadBaseDto
    {
        public int StockCount { get; set; }
    }
}
