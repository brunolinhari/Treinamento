using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Models.Validations
{
    public class ProdutoValidations : AbstractValidator<Produto>
    {
        public ProdutoValidations()
        {
            RuleFor(x => x.Descricao).NotEmpty().Length(4, 100).WithMessage("Descrição precisa ser informada!");
            RuleFor(x => x.Valor).NotEmpty().WithMessage("Valor do produto precisa ser preenchido!");
        }
    }
}
