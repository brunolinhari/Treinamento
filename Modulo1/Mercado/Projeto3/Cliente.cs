using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Cliente : Entity
    {
        //public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
