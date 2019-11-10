using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Projeto3
{
    public abstract class BaseRepository<Entidade> : IBaseRepository<Entidade> where Entidade : Entity 
    {
        //C - Create (Insert)
        //R - Read(Select)
        //U - Update(Update)
        //D - Delete(Delete)

        public Projeto3Context Context { get; set; }

        public BaseRepository()
        {
            Context = new Projeto3Context();
        }

        public void Apagar(int Id)
        {
            Entidade entidadeDB = Obter(Id);
            if (entidadeDB != null)
            {
                Context.Set<Entidade>().Remove(entidadeDB);
                Context.SaveChanges();
            }
        }

        public void Editar(Entidade entidade)
        {
            Context.Entry<Entidade>(entidade).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
        }

        public void Inserir(Entidade entidade)
        {
            Context.Set<Entidade>().Add(entidade);
            Context.SaveChanges();
        }

        public virtual Entidade Obter(int Id)
        {
            return Context.Set<Entidade>().Where(x => x.Id == Id).FirstOrDefault();
        }

        public virtual IEnumerable<Entidade> Obter()
        {
            return Context.Set<Entidade>().ToList();
        }
    }
}