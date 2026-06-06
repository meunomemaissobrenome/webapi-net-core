using System;
using WebApi_Estoque.Model;
using WebApi_Estoque.RepoSitory.repos;

namespace WebApi_Estoque.Service
{
    public class ServiceCliente
    {
        private readonly ClienteRepository _clienteRepository;

        public ServiceCliente(ClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public async Task SalvarCliente(Cliente cliente)
        {
            await this._clienteRepository.SalvarCliente(cliente);
        }
    }
}

