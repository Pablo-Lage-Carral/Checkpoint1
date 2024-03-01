using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Passaro : Animais
    {
        private double tamanhoAsa;
        public Passaro()
        {
            Console.WriteLine("Esta é a descrição do Passaro:");
        }


        public Passaro(string nome, int idade, Boolean classe, string ruido, double tamanhoAsa)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Ruido: " + ruido);
            Console.WriteLine("Tamanho da asa: " + tamanhoAsa +"cm");
        }


    }
}
