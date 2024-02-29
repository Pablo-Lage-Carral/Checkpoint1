using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint1.Models
{
    public class Macaco : Animais
    {
        private string ruido;

        public Macaco()
        {
            setClasse(true);
        }


        public void RuidoMacaco()
        {
            ruido = "Uh Uh Ah Ah";
            Console.WriteLine(ruido);
        }

        public void NomeMacaco()
        {
            Console.WriteLine("Pedrinho");
        }

        public void DescricaoMacaco()
        {
            Console.WriteLine("O macaco pula de galho em galho de árvore em árovre");
        }


    }




}
