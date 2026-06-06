using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi_Estoque.Model;
using WebApi_Estoque.Service;

namespace WebApi_Estoque.Controllers
{
    [ApiController]
    [Route("produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly ServiceProduto _produtoService;

        public ProdutoController(ServiceProduto produto)
        {
            this._produtoService = produto;
        }

        [HttpPost("salvarproduto")]
        public async Task<ActionResult> SalvarProduto([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return NotFound();
            }

            await this._produtoService.SalvarProduto(produto);

            return Ok();

        }

    }

}

