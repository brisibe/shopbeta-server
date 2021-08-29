using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.DTO.Requests
{
    public class OrderItemRequestDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Subtotal { get; set; }

    }
}
