using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Restaurante
    {
        private string nomeRestaurante;
        private int quantidadeMesa;
        private int quantidadeCadeira;

        public Restaurante()
        {
            Console.WriteLine("Olá, Bem-Vindo ao nosso restaurante FIAP dos Animais");
            Console.WriteLine("");
            Console.WriteLine("Veja se há espaço para você se sentar e aproveitar");
        }


        public Restaurante(string nomeRestaurante, int quantidadeMesa, int quantidadeCadeira)
        {
            Console.WriteLine("Nome: " + nomeRestaurante);
            Console.WriteLine("Idade: " + quantidadeMesa);
            Console.WriteLine("Classe: " + quantidadeMesa);
        }
    }


}
