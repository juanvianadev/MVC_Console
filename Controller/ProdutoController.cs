using System.Collections.Generic;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();
        
        public void MostrarProdutos(){
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
    }
}