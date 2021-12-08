﻿using System.ComponentModel.DataAnnotations;

namespace BeGreen.Dtos.Parceiro
{
    public class UpdateParceiroDto
    {
        [Required(ErrorMessage = "O campo id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O campo ramo é obrigatório")]
        public string Ramo { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
    }
}
