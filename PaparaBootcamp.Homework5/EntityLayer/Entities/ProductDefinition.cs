﻿using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class ProductDefinition : BaseEntity
    {
        public int ProductId { get; set; }
        public int StockCount { get; set; }
    }
}
