using System;

namespace ClasseProduto
{
    class Usuario
    {
        public string Nome;// isso é un campo
        public string Senha;
    }
    class Produto
    {
        public string Nome {get; set;}
        public decimal Preco {get; set; }
        public int Quantidade {get; set;}
    }
}
