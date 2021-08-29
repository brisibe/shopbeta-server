using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shopbeta.Core.Models
{
    public class Product
{
        [Column("ProductId")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage ="product name is required")]
        [MaxLength(50, ErrorMessage = "Name should not be more than 50 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product category is required")]
        public string Category { get; set; }

        public string Photo { get; set; }
         
        public string Description { get; set; }

        [Required(ErrorMessage = "product price is required")]
        public int Price { get; set; }

        public string SellerName { get; set; }

        public User User { get; set; }


        
        

}
}
