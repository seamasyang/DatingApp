using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatingAppApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage ="the Username field is required")]
        [MinLength(3)]
        public string Username { get; set; }

        [Required(ErrorMessage ="the Password field is requried")]
        [MinLength(4), MaxLength(8)]
        public string Password { get; set; }
    }
}
