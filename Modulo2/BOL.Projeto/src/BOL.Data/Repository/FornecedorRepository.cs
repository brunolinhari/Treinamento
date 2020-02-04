using BOL.Busines.Interfaces;
using BOL.Busines.Model;
using BOL.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ApiContext apiContext) 
            : base(apiContext)
        {

        }
    }
}
