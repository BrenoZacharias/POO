using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    class Esportivo : Carro
    {
        public override void seAutoDescrever()
        {
            Console.WriteLine("Tenho freios maiores e motores mais potentes \n");
        }
    }
}
