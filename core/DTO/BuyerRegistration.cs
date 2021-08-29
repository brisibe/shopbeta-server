using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace shopbeta.Core.DTO
{
  public  class BuyerRegistration
    {
      
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(12, ErrorMessage ="firstname should not exceed 12 letters")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Input password")]
        public string Password { get; set; }

        public string Role { get; set; } = "Buyer";

      
    }
}
