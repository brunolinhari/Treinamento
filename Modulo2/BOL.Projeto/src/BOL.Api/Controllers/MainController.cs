using BOL.Busines.Notificações;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOL.Api.Controllers
{
    [ApiController]
    [Authorize]
    public abstract class MainController : ControllerBase
    {
        private INotificador _notificador;
        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected ActionResult Result(object obj = null)
        {
            //Validações Ok
            if (!_notificador.TemNotificacao())
            {
                return Ok(new
                {
                    sucesso = true,
                    Data = obj
                });
            }

            return BadRequest(new
            {
                sucesso = false,
                erros = _notificador.ObterNotificacoes().Select(n => n.Mensagem)
            });
        }

        protected ActionResult Result(ModelStateDictionary modelState)
        {
            ObterNotificacaoModelInvalida(modelState);
            return Result();
        }

        protected void ObterNotificacaoModelInvalida(ModelStateDictionary modelState)
        {

            var erros = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in erros)
            {
                string mensagemErro = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                _notificador.Handle(new Notificacao(mensagemErro));
            }
        }

        protected void NotificarErro(string erro)
        {
            _notificador.Handle(new Notificacao(erro));
        }
    }
}
