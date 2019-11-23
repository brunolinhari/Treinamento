using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.DAL
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly Context _context;

        public ProdutoRepository(Context context)
        {
            _context = context;
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Apagar(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public void Editar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Produto Obter(int Id)
        {
            return _context.Produtos.Where(p => p.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Produto> Obter()
        {
            return _context.Produtos.ToList();
        }
    }
}
