using System;
using WebApi_Estoque.Model;
using WebApi_Estoque.RepoSitory.Context;

namespace WebApi_Estoque.RepoSitory.repos
{
    public class ClienteRepository
    {
        private readonly DataBaseContext _context;

        public ClienteRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SalvarCliente(Cliente cliente)
        {
            await this._context.AddAsync(cliente);
            this._context.SaveChanges();
        }
    }
}

