using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterForncedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

        Task<Endereco> ObterEnderecoPorFornecedor(Guid forncedorId);

        Task RemoverEnderecoFornecedor(Endereco? endereco);
    }
}
