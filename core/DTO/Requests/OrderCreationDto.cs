using shopbeta.Core.Helper;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.DTO.Requests
{
   public class OrderCreationDto
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int OrderNumber { get; set; } = GenerateOrderNumber.generate();

        public int TotalPrice { get; set; }

        public ICollection<OrderItem> Items { get; set; }



    }
}
