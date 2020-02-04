using AutoMapper;
using BOL.Api.ViewModel;
using BOL.Busines.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOL.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorAdicionarViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorEditarViewModel>().ReverseMap();
            
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoAdicionarViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoEditarViewModel>().ReverseMap();
        }
    }
}
