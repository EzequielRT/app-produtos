using Business.Models.Fornecedores;
using Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f => f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public override async Task Remover(Guid id)
        {
            var fornecedor = await ObterPorId(id);
            fornecedor.Ativo = false;

            await Atualizar(fornecedor);
        }
    }
}
