using System;
using System.Collections.Generic;

namespace Projeto.classes
{
    public class Marca
    {
        //Meus Atributos estao privados
        public int Codigo { get; set; }
        
        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> Marcas {get; set; }
        
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();
            
            Console.WriteLine("Digite o codigo da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;

        }

        public void Listar(){

            Console.WriteLine("Marcas cadastradas");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Marca : {item.NomeMarca}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
                
            }
        }
        
        public void Deletar(int cod){
            
            Marca marcaDelete = Marcas.Find(x => x.Codigo == cod );
            Marcas.Remove(marcaDelete);
        }
        
    }
}