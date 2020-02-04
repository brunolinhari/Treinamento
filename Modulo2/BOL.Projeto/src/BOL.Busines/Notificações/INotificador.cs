using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Busines.Notificações
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
