using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Model
{
    public class Produto
    {
        public int Codigo { get; set; } 

        public string Nome { get; set; }
        
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string pasta = PATH.Split("/")[0];
            //verificação se a pasta existe

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            //Verificação se o arquivo existe

            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        public List<Produto> Ler(){
            List<Produto> produtos = new List<Produto>();
            //Coletar informações do csv

            string[] linhas =File.ReadAllLines(PATH);
            //Separar atributos pelo ";"

            foreach (var item in linhas){
                string[] atributos = item.Split(";");   
                //Criação de um produto vazio

                Produto prod    = new Produto();
                prod.Codigo     = int.Parse(atributos[0]);
                prod.Nome       = atributos[1];
                prod.Preco      = float.Parse(atributos[2]);

                produtos.Add(prod);
            }

            
            return produtos;
        }

        public void Inserir(Produto p){
            //Preparar um array de string para metodo PrepararLinhaCSV
            string[] linhas = {PrepararLinhaCSV(p) };
            //Inserir um array de linhas no arquivo
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhaCSV(Produto prod){

            //Preparamos a linha para o formato do CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco};";
        }

    }
}