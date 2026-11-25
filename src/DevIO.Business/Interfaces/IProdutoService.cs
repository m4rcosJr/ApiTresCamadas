using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicioanr(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid Id);
    }
}
