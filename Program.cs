using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
             Jogador Cr7 = new Jogador();
            Cr7.Nome= "messi";
            Cr7.Altura = 1.80f;
           Cr7.Peso = 80f;
            Cr7.Nascimento = DateTime.Parse("24/06/1987");
           Cr7.Posicao = "Atacante";
            
            Console.WriteLine(Cr7.CalcularIdade());
            Console.WriteLine(Cr7.VerificarAposentadoria());
            
        }
    
        
    }
}