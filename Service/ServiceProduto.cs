using System;
using WebApi_Estoque.Model;
using WebApi_Estoque.RepoSitory.repos;

namespace WebApi_Estoque.Service
{
    public class ServiceProduto
    {
        private readonly ProdutoRepository _produtoRepository;

        public ServiceProduto(ProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }

        public async Task SalvarProduto(Produto produto)
        {
            await this._produtoRepository.SalvarProduto(produto);

        }

    }
}

