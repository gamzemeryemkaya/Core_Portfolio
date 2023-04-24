using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Image Url'ini girin")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Lütfen  kullanıcı adınızı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mailinizi girin")]
        public string Mail { get; set; }
    }
}
