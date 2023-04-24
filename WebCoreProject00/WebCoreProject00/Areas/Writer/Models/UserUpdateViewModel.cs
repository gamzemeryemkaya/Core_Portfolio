using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreProject00.Areas.Writer.Models
{
    public class UserUpdateViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureURL { get; set; }
        public IFormFile Picture { get; set; }
    }
}
