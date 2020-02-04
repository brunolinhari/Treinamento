using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Busines.Notificações
{
    public class Notificacao
    {
        public string  Mensagem { get; }

        public Notificacao(String mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
