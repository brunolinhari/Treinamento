using System;

namespace BOL.Busines.Model
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}