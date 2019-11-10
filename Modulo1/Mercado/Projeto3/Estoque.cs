using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public class Estoque : Entity
    {
        //public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Saldo { get; set; }
        public int Minimo { get; set; }
    }
}
