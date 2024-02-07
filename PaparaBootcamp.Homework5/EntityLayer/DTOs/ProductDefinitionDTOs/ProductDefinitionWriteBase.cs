using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.ProductDefinitionDTOs
{
    public class ProductDefinitionWriteBase
    {
        public int ProductId { get; set; }
        public int StockCount { get; set; }
    }
}
