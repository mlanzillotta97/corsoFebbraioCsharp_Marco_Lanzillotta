using System;

namespace BarDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuaProgramma = true;

            while (continuaProgramma)
            {
                Console.WriteLine("\n===== BAR VIRTUALE =====");
                Console.WriteLine("1 - Crea nuova bevanda");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");

                string sceltaMenu = Console.ReadLine();

                switch (sceltaMenu)
                {
                    case "1":

                        IBevanda bevanda = null;

                        Console.WriteLine("\nScegli bevanda base:");
                        Console.WriteLine("1 - Caffè");
                        Console.WriteLine("2 - Tè");
                        Console.Write("Scelta: ");

                        string baseScelta = Console.ReadLine();

                        if (baseScelta == "1")
                            bevanda = new Caffe();
                        else if (baseScelta == "2")
                            bevanda = new Te();
                        else
                        {
                            Console.WriteLine("Bevanda non valida");
                            break;
                        }

                        bool aggiungi = true;

                        while (aggiungi)
                        {
                            Console.WriteLine("\nAggiungi ingrediente:");
                            Console.WriteLine("1 - Latte");
                            Console.WriteLine("2 - Cioccolato");
                            Console.WriteLine("3 - Panna");
                            Console.WriteLine("0 - Fine ordine");
                            Console.Write("Scelta: ");

                            string decorazione = Console.ReadLine();

                            switch (decorazione)
                            {
                                case "1":
                                    bevanda = new ConLatte(bevanda);
                                    break;

                                case "2":
                                    bevanda = new ConCioccolato(bevanda);
                                    break;

                                case "3":
                                    bevanda = new ConPanna(bevanda);
                                    break;

                                case "0":
                                    aggiungi = false;
                                    break;

                                default:
                                    Console.WriteLine("Ingrediente non valido");
                                    break;
                            }
                        }

                        Console.WriteLine("\n===== ORDINE =====");
                        Console.WriteLine("Bevanda: " + bevanda.Descrizione());
                        Console.WriteLine("Costo totale: " + bevanda.Costo() + " €");

                        break;

                    case "0":
                        continuaProgramma = false;
                        break;

                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            }

            Console.WriteLine("\nProgramma terminato.");
        }
    }
}