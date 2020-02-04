using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Busines.Interfaces;
using BOL.Busines.Model;
using BOL.Busines.Notificações;
using BOL.Busines.Validations;
using FluentValidation.Results;

namespace BOL.Busines.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        public async Task<bool> Apagar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Apagar(fornecedor);
            return true;
        }

        public async Task<bool> Editar(Fornecedor fornecedor)
        {
            if (!EfetuarValidacao(new FornecedorValidation(), fornecedor))
            {
                return false;
            }

            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id).Result.Any())
            {
                Notificar("Documento Inválido");
                return false;
            }
            await _fornecedorRepository.Editar(fornecedor);
            return true;
        }

        public async Task<bool> Inserir(Fornecedor fornecedor)
        {
            if (!EfetuarValidacao(new FornecedorValidation(), fornecedor))
            {
                return false;
            }

            if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Documento Inválido");
                return false;
            }            
            await _fornecedorRepository.Inserir(fornecedor);
            return true;
        }
        public void Dispose()
        {
            _fornecedorRepository.Dispose();
        }

    }
}
