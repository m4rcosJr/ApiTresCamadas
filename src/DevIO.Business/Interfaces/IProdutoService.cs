using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicioanr(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid Id);
    }
}
