using System;
using System.Collections.Generic;
using MVC_Console.Model;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos){
            foreach (Produto item in produtos){
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine();
            }
        }
    }
}