using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ClienteRepository: IClienteRepository
    {
        public static object inserir;

        //C - Create (Insert)
        //R - Read(Select)
        //U - Update(Update)
        //D - Delete(Delete)

        public Projeto2Context Context { get; set; }

        public ClienteRepository()
        {
            Context = new Projeto2Context();
        }

        public void Inserir(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }

        public void Editar(Cliente cliente)
        {
            //Editar Modelo 1
            Context.Entry<Cliente>(cliente).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

            //Editar Modelo 2
            //Conta contaDB = Obter(conta.Id);
        }

        public void Alterar(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }

        public void Apagar(int id)
        {
            Cliente clienteDB = Obter(id);
            if (clienteDB != null)
            {
                Context.Clientes.Remove(clienteDB);
                Context.SaveChanges();
            }
        }

        public Cliente Obter(int id)
        {
            return Context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Cliente> Obter()
        {
            throw new NotImplementedException();
        }
    }
}
