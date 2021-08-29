using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.Models
{
   public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; } 

        public int TotalPrice { get; set; }

        public ICollection<OrderItem> Items { get; set; }

        public User User { get; set; }
    }
}
