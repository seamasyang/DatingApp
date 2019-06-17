﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatingAppApi.Dtos
{
    public class UserForLoginDto
    {
        [MinLength(3)]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
