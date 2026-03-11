using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scegli la torta base (cioccolato, vaniglia, frutta):");
        string scelta = Console.ReadLine();

        ITorta torta = TortaFactory.CreaTortaBase(scelta);

        while (true)
        {
            Console.WriteLine("Aggiungi ingrediente (panna, fragole, glassa) oppure 'fine':");
            string ingrediente = Console.ReadLine().ToLower();

            if (ingrediente == "fine")
                break;

            switch (ingrediente)
            {
                case "panna":
                    torta = new ConPanna(torta);
                    break;

                case "fragole":
                    torta = new ConFragole(torta);
                    break;

                case "glassa":
                    torta = new ConGlassa(torta);
                    break;

                default:
                    Console.WriteLine("Ingrediente non valido");
                    break;
            }
        }

        Console.WriteLine("\nDescrizione finale:");
        Console.WriteLine(torta.Descrizione());
    }
}