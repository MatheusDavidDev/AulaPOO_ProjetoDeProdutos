using System;
using System.Collections.Generic;

namespace Projeto.classes
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca { get; set; }

        public Usuario CadastradoPor { get; set; }

        public List<Produto> ListaDeProdutos { get; set; }

        public void Cadastrar(){

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o codigo do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;
            
            // Atribuimos nossa marca atraves de um metodo criado para cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            // Atribuimos o usuario atraves do metodo construtor 
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);
    
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
             Console.WriteLine($"Codigo: {item.Codigo}");
             Console.WriteLine($"Produto: {item.NomeProduto}");
             Console.WriteLine($"Preco: R${item.Preco}");
             Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
             Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
             Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
             Console.WriteLine();
             
            }
            Console.ResetColor();
        }
        
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
        
        
        
        
        
        
        
        
    }
}