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

        public void CadastrarProduto(){
            Produto produto = new Produto();

            Console.WriteLine($"Digite o Código do Produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Nome do Produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o Preço do Produto: ");
            produto.Preco = float.Parse(Console.ReadLine());
            
           return produto;
        }
    }
}