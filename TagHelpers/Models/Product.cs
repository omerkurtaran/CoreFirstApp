using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fiyat Giriniz")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok Giriniz")]
        public int Stock { get; set; }
    }
}
