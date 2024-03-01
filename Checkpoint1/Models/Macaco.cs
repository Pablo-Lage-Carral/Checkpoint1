using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Macaco : Animais
    {
        private int quantidadeBananas;

        public Macaco()
        {
            Console.WriteLine("Esta é a descrição do Macaco:");
        }

        public Macaco(string nome, int idade, Boolean classe, string ruido, int quantidadeBananas) 
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Ruido: " + ruido);
            Console.WriteLine("Quantidade de bananas na gaiola: ");
        }




    }




}
