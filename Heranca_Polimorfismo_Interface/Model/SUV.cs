using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    class SUV : Carro
    {
        public override void seAutoDescrever()
        {
            Console.WriteLine("Sou mais alto, tenho uma carroceria alta e ampla, " +
                "tenho facilidade em transportar várias pessoas e cargas \n");
        }
    }
}
