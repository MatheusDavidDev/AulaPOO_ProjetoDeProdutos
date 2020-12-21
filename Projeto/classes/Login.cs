using System;

namespace Projeto.classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Console.ResetColor();
            
            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
                GerarMenu();
            }   
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();
            

            string opcao = "n";

            do
            {
                Console.WriteLine($"Escola uma opcao:");
                Console.WriteLine($"1 - Cadastrar Produto");
                Console.WriteLine($"2 - Listar Produtos");
                Console.WriteLine($"3 - Deletar Produto");
                Console.WriteLine($"4 - Cadastar Marca");
                Console.WriteLine($"5 - Listar Marca");
                Console.WriteLine($"6 - Deletar Marca");
                Console.WriteLine($"5 - Listar Marca");
                Console.WriteLine("0 - Sair da aplicacao");

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;

                    case "2":
                        produto.Listar();
                        break;

                    case "3":
                        Console.WriteLine($"Digite um codigo para excluir");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;

                    case "4":
                        marca.CadastrarMarca();
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":
                        Console.WriteLine($"Digite um codigo para excluir");
                        int code = int.Parse(Console.ReadLine());
                        marca.Deletar(code);
                        break;

                    default:
                        break;
                }
                
                
                
                
            } while (opcao != "0");
        }

        public void Logar(Usuario usuario){

            Console.WriteLine($"Digite seu email: ");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine($"Digite sua senha");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine($"Loguin efetuado");
                
            }else{
                Console.WriteLine($"Falha ao logar na aplicacao loguin");
                
            }
            
        }

        public void Deslogar(){
            Logado = false;
        }
        
        
    }
}