using BOL.Busines.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Busines.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome).Length(2, 200).WithMessage("Nome precisa ter entre 2 e 100 caracteres")
                    .NotEmpty().WithMessage("Nome precisa ser fornecedo");
            RuleFor(p => p.Descricao).Length(2, 1000).WithMessage("A descrição precisa ter entre 2 e 1000 caracteres")
                    .NotEmpty().WithMessage("Nome precisa ser fornecedo");
        }
    }
}
