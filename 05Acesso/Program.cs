using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
          Produto p = new Produto();
          p.nome = "Maria"; // Nome é um atributo público, diferente de valor. 
        }
    }
}
