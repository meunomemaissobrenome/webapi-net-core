using System;
using System.Text.Json.Serialization;

namespace WebApi_Estoque.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        [JsonPropertyName("codigoBarras")]
        public Guid CodigoDeBarra { get; set; }
    }
}

