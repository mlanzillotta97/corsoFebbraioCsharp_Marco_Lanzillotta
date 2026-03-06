using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Animale> fattoria = new List<Animale>();

    static void Main(string[] args)
    {
        fattoria.Add(new Mucca("Milly", 5, 25.5));
        fattoria.Add(new Gallina("Chicca", 2, 100));
        fattoria.Add(new Pecora("Shaun", 3, "Morbida"));

        bool esci = false;
        while (!esci)
        {
            Console.WriteLine("\nMenu Fattoria:");
            Console.WriteLine("1. Visualizza tutti gli animali");
            Console.WriteLine("2. Visualizza animali per tipo");
            Console.WriteLine("3. Aggiungi animale");
            Console.WriteLine("4. Modifica animale");
            Console.WriteLine("5. Cancella animale");
            Console.WriteLine("6. Fai emettere il verso a tutti gli animali");
            Console.WriteLine("0. Esci");
            Console.Write("Scelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    StampaTuttiAnimali();
                    break;
                case "2":
                    StampaAnimaliPerTipo();
                    break;
                case "3":
                    AggiungiAnimale();
                    break;
                case "4":
                    ModificaAnimale();
                    break;
                case "5":
                    CancellaAnimale();
                    break;
                case "6":
                    FaiVersareTutti();
                    break;
                case "0":
                    esci = true;
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }

    static void StampaTuttiAnimali()
    {
        if (fattoria.Count == 0)
        {
            Console.WriteLine("Nessun animale in fattoria.");
            return;
        }

        Console.WriteLine("Animali in fattoria:");
        foreach (var a in fattoria)
        {
            a.MostraInfo();
            Console.WriteLine();
        }
    }

    static void StampaAnimaliPerTipo()
    {
        Console.WriteLine("Scegli il tipo da visualizzare:");
        Console.WriteLine("1. Mucca");
        Console.WriteLine("2. Gallina");
        Console.WriteLine("3. Pecora");
        Console.WriteLine("4. Maiale");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine();

        IEnumerable<Animale> selezionati = scelta switch
        {
            "1" => fattoria.OfType<Mucca>(),
            "2" => fattoria.OfType<Gallina>(),
            "3" => fattoria.OfType<Pecora>(),
            "4" => fattoria.OfType<Maiale>(),
            _ => null
        };

        if (selezionati == null || !selezionati.Any())
        {
            Console.WriteLine("Nessun animale di questo tipo.");
            return;
        }

        foreach (var a in selezionati)
        {
            a.MostraInfo();
            Console.WriteLine();
        }
    }

    static void AggiungiAnimale()
    {
        Console.WriteLine("Scegli il tipo di animale da aggiungere:");
        Console.WriteLine("1. Mucca");
        Console.WriteLine("2. Gallina");
        Console.WriteLine("3. Pecora");
        Console.WriteLine("4. Maiale");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Età: ");
        if (!int.TryParse(Console.ReadLine(), out int eta))
        {
            Console.WriteLine("Età non valida.");
            return;
        }

        switch (scelta)
        {
            case "1":
                Console.Write("Latte prodotto (litri): ");
                if (double.TryParse(Console.ReadLine(), out double latte))
                {
                    fattoria.Add(new Mucca(nome, eta, latte));
                    Console.WriteLine("Mucca aggiunta.");
                }
                else
                    Console.WriteLine("Valore latte non valido.");
                break;
            case "2":
                Console.Write("Uova prodotte: ");
                if (int.TryParse(Console.ReadLine(), out int uova))
                {
                    fattoria.Add(new Gallina(nome, eta, uova));
                    Console.WriteLine("Gallina aggiunta.");
                }
                else
                    Console.WriteLine("Valore uova non valido.");
                break;
            case "3":
                Console.Write("Tipo di lana: ");
                string lana = Console.ReadLine();
                fattoria.Add(new Pecora(nome, eta, lana));
                Console.WriteLine("Pecora aggiunta.");
                break;
            case "4":
                Console.Write("Peso (kg): ");
                if (double.TryParse(Console.ReadLine(), out double peso))
                {
                    fattoria.Add(new Maiale(nome, eta, peso));
                    Console.WriteLine("Maiale aggiunto.");
                }
                else
                    Console.WriteLine("Valore peso non valido.");
                break;
            default:
                Console.WriteLine("Scelta non valida.");
                break;
        }
    }

    static void ModificaAnimale()
    {
        if (fattoria.Count == 0)
        {
            Console.WriteLine("Nessun animale da modificare.");
            return;
        }

        Console.WriteLine("Seleziona l'animale da modificare (numero):");
        for (int i = 0; i < fattoria.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {fattoria[i].GetType().Name} - {fattoria[i].Nome}");
        }

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > fattoria.Count)
        {
            Console.WriteLine("Selezione non valida.");
            return;
        }

        Animale animale = fattoria[index - 1];

        Console.Write($"Nuovo nome (lascia vuoto per non cambiare) [{animale.Nome}]: ");
        string nuovoNome = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(nuovoNome))
            animale.Nome = nuovoNome;

        Console.Write($"Nuova età (lascia vuoto per non cambiare) [{animale.Eta}]: ");
        string nuovaEtaStr = Console.ReadLine();
        if (int.TryParse(nuovaEtaStr, out int nuovaEta))
            animale.Eta = nuovaEta;

        switch (animale)
        {
            case Mucca m:
                Console.Write($"Nuovo latte prodotto (litri) [{m.LatteProdottoLitri}]: ");
                if (double.TryParse(Console.ReadLine(), out double nuovoLatte))
                    m.LatteProdottoLitri = nuovoLatte;
                break;
            case Gallina g:
                Console.Write($"Nuovo numero uova prodotte [{g.UovaProdotte}]: ");
                if (int.TryParse(Console.ReadLine(), out int nuoveUova))
                    g.UovaProdotte = nuoveUova;
                break;
            case Pecora p:
                Console.Write($"Nuovo tipo di lana [{p.TipoLana}]: ");
                string nuovaLana = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nuovaLana))
                    p.TipoLana = nuovaLana;
                break;
            case Maiale ma:
                Console.Write($"Nuovo peso (kg) [{ma.Peso}]: ");
                if (double.TryParse(Console.ReadLine(), out double nuovoPeso))
                    ma.Peso = nuovoPeso;
                break;
        }

        Console.WriteLine("Animale modificato.");
    }

    static void CancellaAnimale()
    {
        if (fattoria.Count == 0)
        {
            Console.WriteLine("Nessun animale da cancellare.");
            return;
        }

        Console.WriteLine("Seleziona l'animale da cancellare (numero):");
        for (int i = 0; i < fattoria.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {fattoria[i].GetType().Name} - {fattoria[i].Nome}");
        }

        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > fattoria.Count)
        {
            Console.WriteLine("Selezione non valida.");
            return;
        }

        fattoria.RemoveAt(index - 1);
        Console.WriteLine("Animale cancellato.");
    }

    static void FaiVersareTutti()
    {
        if (fattoria.Count == 0)
        {
            Console.WriteLine("Nessun animale in fattoria.");
            return;
        }

        Console.WriteLine("I versi degli animali:");
        foreach (var a in fattoria)
        {
            Console.Write($"{a.Nome} dice: ");
            a.Verso();
        }
    }
}