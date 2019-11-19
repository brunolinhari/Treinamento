using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost]
        public void Adicionar(Produto produto)
        {
            _produtoRepository.Adicionar(produto);
        }

        [HttpDelete("{Id}")]
        public void Aapagar(int Id)
        {
            var produto = _produtoRepository.Obter(Id);

            _produtoRepository.Apagar(produto);
        }

        [HttpPut]
        public void Editar(Produto produto)
        {
            _produtoRepository.Editar(produto);
        }

        [HttpGet]
        public IEnumerable<Produto> Obter()
        {
            return _produtoRepository.Obter();
        }

        [HttpGet("{Id}")]
        public Produto Obter(int Id)
        {
            return _produtoRepository.Obter(Id);
        }
    }
}