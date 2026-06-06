using System;
namespace WebApi_Estoque.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string? Complemento { get; set; }
    }
}

