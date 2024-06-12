﻿
using DevIO.BusinessOrDomain.EntitiesOrModels;
using FluentValidation;

namespace DevIO.BusinessOrDomain.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation() 
        {
            RuleFor(e => e.Logradouro).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Bairro).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Cep).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Cidade).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Estado).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(e => e.Numero).NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O campo {PropertyName}, precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
