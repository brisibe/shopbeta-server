using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopbeta.Core.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }

        public string Role { get; set; }



    }
}
