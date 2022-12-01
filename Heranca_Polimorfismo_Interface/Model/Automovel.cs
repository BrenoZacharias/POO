using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    abstract class Automovel : Ligavel, Desligavel
    {
        public void desligar()
        {
            Console.WriteLine("Automóvel desligando \n");
        }

        public void ligar()
        {
            Console.WriteLine("Automóvel ligando \n");
        }

        public abstract void acelerar();

        public abstract void frear();
    }
}


