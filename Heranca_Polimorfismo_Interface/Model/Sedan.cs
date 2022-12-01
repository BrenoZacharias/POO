using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automóveis.Model
{
    class Sedan : Carro
    {
        public override void seAutoDescrever()
        {
            Console.WriteLine("Tenho um volume maior no porta malas, uma traseira mais avantajada e " +
                "4 portas \n");
        }
    }
}
