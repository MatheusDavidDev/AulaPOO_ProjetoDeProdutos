using System;

namespace Projeto.classes
{
    public class Usuario
    {
        public Usuario(){
            // Cadastrar o usuario automaticamente quando essa classe for instanciada 
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;


        }
        int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            Nome = "Paulo";
            Email = "admim@admim.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(int cod){
            Nome = "";
            Email = "";
            Senha = "";
            //2020-12-21T08:47:25
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }
        
        
        
        
        
        
    }
}