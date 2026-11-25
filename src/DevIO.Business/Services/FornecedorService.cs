using DevIO.Business.Interfaces;
using DevIO.Business.Models;

namespace DevIO.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        public Task Adicioanr(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
