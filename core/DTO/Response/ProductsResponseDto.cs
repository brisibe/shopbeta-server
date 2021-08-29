using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.DTO.Response
{
    public class ProductsResponseDto
    {
        public Guid productId { get; set; } 
        public string Name { get; set; }

        public string Category { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string SellerName { get; set; }
    }
}
