using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopbeta.Core.Models
{
  public  class OrderItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Subtotal { get; set; }

        public Order Order { get; set; }



        

    }
}
