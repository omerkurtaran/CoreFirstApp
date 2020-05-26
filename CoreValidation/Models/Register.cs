using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreValidation.Models
{
    public class Register
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail giriniz")]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Parolalar Uyuşmuyor")]
        [StringLength(8, ErrorMessage = "Max 8 karekter olmalıdır min 6 olmalı", MinimumLength = 6)]
        public string RePassword { get; set; }

        [UIHint("Date")]
        [Required(ErrorMessage = "DOğum tarihi giriniz")]
        public DateTime BirthDate { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
