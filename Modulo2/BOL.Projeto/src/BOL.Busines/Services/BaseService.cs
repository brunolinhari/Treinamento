using BOL.Busines.Model;
using BOL.Busines.Notificações;
using BOL.Busines.Validations;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Busines.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool EfetuarValidacao<V, E>(V validacao, E entidade)
            where V : AbstractValidator<E>
            where E : Entity
        {
            ValidationResult result = validacao.Validate(entidade);

            if (!result.IsValid)
            {
                foreach (var err in result.Errors)
                {
                    Notificar(err.ErrorMessage);
                }
                return false;
            }
            return true;
        }
    }
}
