using System;
using System.Collections.Generic;

namespace OfficinaMeccanica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veicolo> officina = new List<Veicolo>();

            officina.Add(new Auto("AA123BB"));
            officina.Add(new Moto("CC456DD"));
            officina.Add(new Camion("EE789FF"));

            Console.WriteLine("=== OFFICINA MECCANICA ===\n");

            foreach (Veicolo v in officina)
            {
                Console.WriteLine("Targa: " + v.Targa);
                v.Ripara();  // Polimorfismo
                Console.WriteLine();
            }
        }
    }
}