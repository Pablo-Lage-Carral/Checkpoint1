using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Cobra : Animais
    {
        private string tipoVeneno;


        public Cobra()
        {
            Console.WriteLine("Esta é a descrição da Cobra:");
        }


        public Cobra(string nome, int idade, Boolean classe, string ruido, string tipoVeneno)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Classe: " + classe);
            Console.WriteLine("Ruido: " + ruido);
            Console.WriteLine("Tipo de veneno da cobra: " + tipoVeneno);
        }

    }
}
