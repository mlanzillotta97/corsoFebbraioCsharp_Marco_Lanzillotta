using System;
using System.Collections.Generic;

namespace GestioneOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operatore> operatori = new List<Operatore>();
            int scelta;

            do
            {
                Console.WriteLine("\n=== MENU GESTIONE OPERATORI ===");
                Console.WriteLine("1 - Aggiungi Operatore Emergenza");
                Console.WriteLine("2 - Aggiungi Operatore Sicurezza");
                Console.WriteLine("3 - Aggiungi Operatore Logistica");
                Console.WriteLine("4 - Stampa tutti gli operatori");
                Console.WriteLine("5 - Esegui compiti (Polimorfismo)");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        OperatoreEmergenza oe = new OperatoreEmergenza();
                        Console.Write("Nome: ");
                        oe.Nome = Console.ReadLine();
                        Console.Write("Turno (giorno/notte): ");
                        oe.Turno = Console.ReadLine();
                        Console.Write("Livello urgenza (1-5): ");
                        oe.LivelloUrgenza = int.Parse(Console.ReadLine());
                        operatori.Add(oe);
                        break;

                    case 2:
                        OperatoreSicurezza os = new OperatoreSicurezza();
                        Console.Write("Nome: ");
                        os.Nome = Console.ReadLine();
                        Console.Write("Turno (giorno/notte): ");
                        os.Turno = Console.ReadLine();
                        Console.Write("Area sorvegliata: ");
                        os.AreaSorvegliata = Console.ReadLine();
                        operatori.Add(os);
                        break;

                    case 3:
                        OperatoreLogistica ol = new OperatoreLogistica();
                        Console.Write("Nome: ");
                        ol.Nome = Console.ReadLine();
                        Console.Write("Turno (giorno/notte): ");
                        ol.Turno = Console.ReadLine();
                        Console.Write("Numero consegne: ");
                        ol.NumeroConsegne = int.Parse(Console.ReadLine());
                        operatori.Add(ol);
                        break;

                    case 4:
                        Console.WriteLine("\n--- ELENCO OPERATORI ---");
                        foreach (Operatore op in operatori)
                        {
                            Console.WriteLine("Nome: " + op.Nome +
                                            " | Tipo: " + op.GetType().Name +
                                            " | Turno: " + op.Turno);
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n--- ESECUZIONE COMPITI ---");
                        foreach (Operatore op in operatori)
                        {
                            Console.Write(op.Nome + " → ");
                            op.EseguiCompito(); // POLIMORFISMO
                        }
                        break;
                }

            } while (scelta != 0);
        }
    }
}