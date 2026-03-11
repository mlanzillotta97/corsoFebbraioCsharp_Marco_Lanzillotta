using System;

class Program
{
    static void Main()
    {
        // ===== FACTORY =====
        // Creazione del piatto base tramite Factory

        Console.WriteLine("Scegli il piatto:");
        Console.WriteLine("1 - Pizza");
        Console.WriteLine("2 - Hamburger");
        Console.WriteLine("3 - Insalata");

        string scelta = Console.ReadLine();
        IPiatto piatto;

        switch (scelta)
        {
            case "1":
                piatto = PiattoFactory.Crea("pizza");
                break;

            case "2":
                piatto = PiattoFactory.Crea("hamburger");
                break;

            case "3":
                piatto = PiattoFactory.Crea("insalata");
                break;

            default:
                Console.WriteLine("Scelta non valida");
                return;
        }

        // ===== DECORATOR =====
        // Aggiunta dinamica di ingredienti

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nAggiungi ingrediente:");
            Console.WriteLine("1 - Formaggio");
            Console.WriteLine("2 - Bacon");
            Console.WriteLine("3 - Salsa");
            Console.WriteLine("0 - Fine");

            string ingrediente = Console.ReadLine();

            switch (ingrediente)
            {
                case "1":
                    piatto = new ConFormaggio(piatto);
                    break;

                case "2":
                    piatto = new ConBacon(piatto);
                    break;

                case "3":
                    piatto = new ConSalsa(piatto);
                    break;

                case "0":
                    continua = false;
                    break;
            }
        }

        // ===== STRATEGY =====
        // Scelta della modalità di preparazione

        Chef chef = new Chef();

        Console.WriteLine("\nScegli la cottura:");
        Console.WriteLine("1 - Fritto");
        Console.WriteLine("2 - Al forno");
        Console.WriteLine("3 - Alla griglia");

        string cottura = Console.ReadLine();

        switch (cottura)
        {
            case "1":
                chef.SetStrategia(new Fritto());
                break;

            case "2":
                chef.SetStrategia(new AlForno());
                break;

            case "3":
                chef.SetStrategia(new AllaGriglia());
                break;
        }

        Console.WriteLine("\nDescrizione piatto:");
        Console.WriteLine(piatto.Descrizione());

        Console.WriteLine("\nPreparazione:");
        Console.WriteLine(chef.PreparaPiatto(piatto));
    }
}