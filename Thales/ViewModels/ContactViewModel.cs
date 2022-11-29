﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.Thales.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5)]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Asunto { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Too long")]
        public string Mensaje { get; set; }
    }
}

