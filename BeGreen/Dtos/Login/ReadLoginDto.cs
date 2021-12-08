﻿using System.ComponentModel.DataAnnotations;

namespace BeGreen.Dtos.Login
{
    public class ReadLoginDto
    {
        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }
    }
}
