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
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace BOL.Api.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class FornecedorsController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly ILogger _logger;

        private readonly IMapper _mapper;

        public FornecedorsController(
            IFornecedorRepository fornecedorRepository, 
            IFornecedorService fornecedorService, 
            IMapper mapper, 
            ILogger<FornecedorsController> logger, 
            INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _fornecedorService = fornecedorService;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Fornecedors
        [HttpGet]
        [ResponseCache(Duration = 20)]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> GetFornecedores()
        {
            return Ok(await _fornecedorRepository.Obter());
        }

        // GET: api/Fornecedors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorViewModel>> GetFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);

            _logger.LogInformation($">>>>>>>>>>>>>>>>>>>>>>>>>ID {id}");
            _logger.LogDebug($">>>>>>>>>>>>>>>>>>>>>>>>>ID {id}");
            _logger.LogError($">>>>>>>>>>>>>>>>>>>>>>>>>ID {id}");

            if (fornecedor == null)
            {
                return NotFound();
            }

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }

        // PUT: api/Fornecedors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor(Guid id, FornecedorEditarViewModel fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            await _fornecedorService.Editar(_mapper.Map<Fornecedor>(fornecedor));

            //return NoContent();
            return Result("Registro alterado com sucesso");
        }

        // POST: api/Fornecedors
        [HttpPost]
        public async Task<ActionResult<FornecedorAdicionarViewModel>> PostFornecedor(FornecedorAdicionarViewModel fornecedor)
        {
            if (!ModelState.IsValid) return Result(ModelState);

            var forn = _mapper.Map<Fornecedor>(fornecedor);

            await _fornecedorService.Inserir(forn);

            //return CreatedAtAction("GetFornecedor", new { id = forn.Id }, fornecedor);
            return Result("Registro incluído com sucesso");
        }

        // DELETE: api/Fornecedors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fornecedor>> DeleteFornecedor(Guid id)
        {
            var fornecedor = await _fornecedorRepository.Obter(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            await _fornecedorService.Apagar(fornecedor);

            //return fornecedor;
            return Result("Registro apagado com sucesso");
        }
    }
}
