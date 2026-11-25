using DevIO.Business.Interfaces;
using DevIO.Business.Models;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
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
    }
}
