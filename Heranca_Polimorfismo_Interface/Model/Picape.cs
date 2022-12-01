using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    class Picape : Carro
    {
        public override void seAutoDescrever()
        {
            Console.WriteLine("Tenho carroceria alta, com uma caçamba externa na parte traseira, " +
                                "possuo uma cabine com dois lugares ou uma cabine \n" +
                                "dupla (para cinco pessoas), tenho 2 ou 4 portas \n");
        }
    }
}
