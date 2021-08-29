using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace shopbeta.Core.DTO.Requests
{
   public class ProductsRequestDto
    {
       

        //[Required(ErrorMessage = "product name is required")]
        [MaxLength(50, ErrorMessage = "Name should not be more than 50 characters long")]
        public string name { get; set; }

        //[Required(ErrorMessage = "Product category is required")]
        public string category { get; set; }

        public IFormFile photo { get; set; }

        public string description { get; set; }

        //[Required(ErrorMessage = "product price is required")]
        public int price { get; set; }

    }
}
