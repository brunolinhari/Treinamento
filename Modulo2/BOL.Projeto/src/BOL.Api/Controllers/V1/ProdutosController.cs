using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BOL.Busines.Model;
using BOL.Data.Context;
using BOL.Busines.Interfaces;
using BOL.Api.ViewModel;
using AutoMapper;
using BOL.Busines.Notificações;
using BOL.Busines.Services;
using System.IO;

namespace BOL.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ProdutosController : MainController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IProdutoService produtoService, IMapper mapper, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        // GET: api/Produtos
        [HttpGet]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> GetFornecedores()
        {
            return Ok(await _produtoRepository.Obter());
        }

        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoViewModel>> GetProduto(Guid id)
        {
            var produto = Ok(await _produtoRepository.Obter(id));

            if (produto == null)
            {
                return NotFound();
            }

            return _mapper.Map<ProdutoViewModel>(produto);
        }

        // PUT: api/Produtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, ProdutoEditarViewModel produto)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != produto.Id)
            {
                return BadRequest();
            }

            await _produtoService.Editar(_mapper.Map<Produto>(produto));

            //return NoContent();
            return Result("Registro alterado com sucesso");
        }

        // POST: api/Produtos
        [HttpPost]
        public async Task<ActionResult<ProdutoAdicionarViewModel>> PostProduto(ProdutoAdicionarViewModel produto)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var nomeImagem = $"{Guid.NewGuid()}.jpg";
            if (!UpLoadImagem(produto.Imagem, nomeImagem))
            {
                return Result();
            }
            
            produto.Imagem = nomeImagem;

            var prod = _mapper.Map<Produto>(produto);

            await _produtoService.Inserir(prod);

            //return CreatedAtAction("GetProduto", new { id = prod.Id }, produto);
            return Result("Registro incluído com sucesso");
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> DeleteProduto(Guid id)
        {
            var produto = await _produtoRepository.Obter(id);
            if (produto == null)
            {
                return NotFound();
            }

            await _produtoService.Apagar(produto);

            //return produto;
            return Result("Registro apagado com sucesso");
        }

        private bool UpLoadImagem(string imagemBase64, string nomeImagem)
        {
            if (string.IsNullOrEmpty(imagemBase64))
            {
                NotificarErro("Necessário informar uma imagem para o produto!");
                return false;
            }

            var imagemByte = Convert.FromBase64String(imagemBase64);
            var pathImagem = Path.Combine("C:", "Temp", nomeImagem);

            System.IO.File.WriteAllBytes(pathImagem, imagemByte);

            return true;
        }
    }
}
