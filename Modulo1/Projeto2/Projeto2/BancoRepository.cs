using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoRepository: IBancoRepository
    {
        //C - Create (Insert)
        //R - Read(Select)
        //U - Update(Update)
        //D - Delete(Delete)

        public Projeto2Context Context { get; set; }

        public BancoRepository()
        {
            Context = new Projeto2Context();
        }
        public void Inserir(Banco banco)
        {
            Context.Bancos.Add(banco);
            Context.SaveChanges();
        }

        public void Editar(Banco banco)
        {
            //Editar Modelo 1
            Context.Entry<Banco>(banco).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

        }

        public void Alterar(Banco banco)
        {
            Context.Bancos.Add(banco);
            Context.SaveChanges();
        }

        public void Apagar(int id)
        {
            Banco bancoDB = Obter(id);
            if (bancoDB != null)
            {
                Context.Bancos.Remove(bancoDB);
                Context.SaveChanges();
            }
        }

        public Banco Obter(int id)
        {
            return Context.Bancos.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Banco> Obter()
        {
            return Context.Bancos.ToList();
        }
    }
}
