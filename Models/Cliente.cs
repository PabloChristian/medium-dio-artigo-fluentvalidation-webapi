using System;
using FluentValidation;
using medium_dio_artigo_fluentvalidation_webapi.Extensions;

namespace medium_dio_artigo_fluentvalidation_webapi.Models
{
  public class Cliente
  {
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }

    public class ClienteValidation : AbstractValidator<Cliente>
    {
      public ClienteValidation()
      {
        RuleFor(x => x.Nome)
          .NotEmpty().WithMessage("Informe o nome do cliente")
          .Length(3,50).WithMessage("O nome deverá ter entre 3 a 50 caracteres");
        RuleFor(x => x.Email)
          .NotEmpty().WithMessage("Informe o e-mail do cliente")
          .EmailAddress().WithMessage("E-mail inválido");
        RuleFor(x => x.DataNascimento)
          .NotEmpty().WithMessage("Informe a data de nascimento do cliente")
          .Must(ClienteMaiorDeIdade).WithMessage("O cliente deverá ter no mínimo 18 anos");
        RuleFor(x => x.Telefone)
          .Phone().WithMessage("Informe um número de telefone válido");
      }
      private static bool ClienteMaiorDeIdade(DateTime dataNascimento) =>
        dataNascimento <= DateTime.Now.AddYears(-18);
    }
  }
}