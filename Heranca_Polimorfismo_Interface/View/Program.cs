using Sistema_de_Automóveis.Model;
using System;

namespace Sistema_de_Automóveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovel a = new Carro();
            a.ligar();
            a.desligar();
            a.acelerar();
            a.frear();

            Carro c = (Carro)a;
            Console.WriteLine("Carro:");
            c.seAutoDescrever();
            
            c = new SUV();
            Console.WriteLine("SUV:");
            c.seAutoDescrever();

            c = new Sedan();
            Console.WriteLine("Sedan:");
            c.seAutoDescrever();

            c = new Picape();
            Console.WriteLine("Picape:");
            c.seAutoDescrever();

            c = new Esportivo();
            Console.WriteLine("Esportivo:");
            c.seAutoDescrever();


        }
    }
}
