using System;
using WebApi_Estoque.Model;
using WebApi_Estoque.RepoSitory.Context;

namespace WebApi_Estoque.RepoSitory.repos
{
    public class ProdutoRepository
    {
        private readonly DataBaseContext _context;

        public ProdutoRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SalvarProduto(Produto produto)
        {
            await this._context.AddAsync(produto);
            this._context.SaveChanges();
        }
    }
}
