using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Animais
    {
        private string nome;
        private int idade;
        private Boolean classe;
        private string ruido;

        public void setRuido(String novoRuido)
        {
            ruido = novoRuido;
        }
        public string getRuido()
        {
            return ruido;

        }

        public void setNome(String novoNome) 
        {
            nome = novoNome;
        } 
        public string getNome()
        {
            return nome;

        }
        public void setIdade(int novaIdade)
        {
            idade = novaIdade;
        }
        public int getIdade()
        {
            return idade;
        }

        public void setClasse(Boolean novaClasse)
        {
            
            classe = novaClasse;
        }
        public Boolean getClasse()
        {
            return classe;
        }

        public void ValidarClasseAnimal()
        {
            switch (classe)
            {
                case true:
                    Console.WriteLine("O animal é vertebrado");
                    break;
                default:
                    Console.WriteLine("O animal é invertebrado");
                    break;
            }
           
        }

    }
}
