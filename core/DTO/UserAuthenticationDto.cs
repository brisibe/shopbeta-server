using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace shopbeta.Core.DTO
{
    public class UserAuthenticationDto
    {
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Input Password")]
        public string Password { get; set; }
    }
}
