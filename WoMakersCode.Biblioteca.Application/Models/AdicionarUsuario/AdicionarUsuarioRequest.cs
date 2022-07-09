﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoMakersCode.Biblioteca.Application.Models.AdicionarUsuario
{
    public class AdicionarUsuarioRequest  
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }

    public class AdicionarUsuarioRequestValidator : AbstractValidator<AdicionarUsuarioRequest>
    {
        public AdicionarUsuarioRequestValidator()
        {
           //criando regra para a propriedade nome
            RuleFor(r => r.Nome).NotEmpty()
                .WithMessage("Nome não pode ser vazio")
                .NotNull()
                .WithMessage("Nome não pode ser nulo")
                ;
        }
    }
}
