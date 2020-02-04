using BOL.Busines.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Busines.Services
{
    public interface IProdutoService : IDisposable
    {
        Task<bool> Inserir(Produto produto);
        Task<bool> Editar(Produto produto);
        Task<bool> Apagar(Produto produto);
    }
}
