using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    class Carro : Automovel
    {
        public override void acelerar()
        {
            Console.WriteLine("Carro acelerando \n");
        }

        public override void frear()
        {
            Console.WriteLine("Carro freando \n");
        }

        public virtual void seAutoDescrever()
        {
            Console.WriteLine("Possuo características básicas de um carro \n");
        }
    }
}
