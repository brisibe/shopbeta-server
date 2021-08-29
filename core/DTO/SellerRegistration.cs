using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace shopbeta.Core.DTO
{
   public class SellerRegistration
    {
        [Required(ErrorMessage ="username is required")]
        [MaxLength (30, ErrorMessage ="Name should not exceed 30" )]
        public string Username { get; set; }

        [Required(ErrorMessage = "Store name is required")]
        public string StoreName { get; set; }
        
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required (ErrorMessage ="Password is required")]
        public string Password { get; set; }

        public string Role { get; set; } = "Seller";

       
    }
}
