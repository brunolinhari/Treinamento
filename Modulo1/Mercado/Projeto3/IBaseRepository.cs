using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    public interface IBaseRepository<T>
    {
        void Inserir(T entidade);

        void Editar(T entidade);

        void Apagar(int Id);

        T Obter(int Id);

        IEnumerable<T> Obter();
    }
    
}
