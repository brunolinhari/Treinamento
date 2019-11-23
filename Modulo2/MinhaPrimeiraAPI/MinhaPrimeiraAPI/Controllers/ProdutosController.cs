using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.DAL;
using MinhaPrimeiraAPI.Models;
using System.Net;
using MinhaPrimeiraAPI.ViewModels;
using AutoMapper;
using MinhaPrimeiraAPI.Models.Validations;
using FluentValidation.Results;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        public readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> Adicionar(ProdutoAdicionarViewModel produtoVM)
        {
            var prd = _mapper.Map<Produto>(produtoVM);

            ValidationResult resultadoValidacao = new ProdutoValidations().Validate(prd);

            if (!resultadoValidacao.IsValid)
            {
                return BadRequest(new
                {
                    erro = resultadoValidacao.Errors.Select(a => a.ErrorMessage)
                });
            }
            //Produto produto = new Produto();
            //produto.Descricao = produtoVM.Descricao;
            //produto.Valor = produtoVM.Valor;

            _produtoRepository.Adicionar(prd);

            return Created(nameof(Adicionar), new { IdCadastrado = prd.Id });
        }

        [HttpDelete("{Id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult Aapagar(int Id)
        {
            var produto = _produtoRepository.Obter(Id);

            _produtoRepository.Apagar(produto);

            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> Editar(ProdutoEditarViewModel produtoVM)
        {
            _produtoRepository.Editar(_mapper.Map<Produto>(produtoVM));
            //_produtoRepository.Editar(new Produto()
            //{
            //    Id = produtoVM.Id,
            //    Descricao = produtoVM.Descricao,
            //    Valor = produtoVM.Valor
            //});

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<IEnumerable<Produto>> Obter()
        {
            //return _produtoRepository.Obter();
            var produtos = _produtoRepository.Obter();

            return Ok(produtos);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public ActionResult<Produto> Obter(int Id)
        {
            //return _produtoRepository.Obter(Id);
            var produto = _produtoRepository.Obter(Id);

            if (produto == null)
                return NotFound(new { mensagem = $"Id {Id} não foi encontrado!"});
            else
                return Ok(produto); 
                
        }
    }
}