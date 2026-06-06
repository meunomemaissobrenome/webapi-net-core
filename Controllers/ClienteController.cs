using System;
using Microsoft.AspNetCore.Mvc;
using WebApi_Estoque.Model;
using WebApi_Estoque.Service;

namespace WebApi_Estoque.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly ServiceCliente _clienteService;

        public ClienteController(ServiceCliente cliente)
        {
            this._clienteService = cliente;
        }

        [HttpPost("salvar cliente")]
        public async Task<ActionResult> SalvarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }

            await this._clienteService.SalvarCliente(cliente);

            return Ok();
        }
    }
}

