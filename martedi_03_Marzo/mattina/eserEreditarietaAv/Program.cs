using System;
using System.Collections.Generic;
using System.Linq;

namespace ScuolaArtistica
{
    class Program
    {
        static List<Corso> corsi = new List<Corso>();

        static void Main(string[] args)
        {
            int scelta;

            do
            {
                Console.WriteLine("\n===== SCUOLA ARTISTICA =====");
                Console.WriteLine("[1] Aggiungi un corso di Musica");
                Console.WriteLine("[2] Aggiungi un corso di Pittura");
                Console.WriteLine("[3] Aggiungi un corso di Danza");
                Console.WriteLine("[4] Aggiungi studente a un corso");
                Console.WriteLine("[5] Visualizza tutti i corsi");
                Console.WriteLine("[6] Cerca corsi per nome docente");
                Console.WriteLine("[7] Esegui metodo speciale di un corso");
                Console.WriteLine("[0] Esci");
                Console.Write("Scelta: ");

                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1: AggiungiCorsoMusica(); break;
                    case 2: AggiungiCorsoPittura(); break;
                    case 3: AggiungiCorsoDanza(); break;
                    case 4: AggiungiStudente(); break;
                    case 5: VisualizzaCorsi(); break;
                    case 6: CercaPerDocente(); break;
                    case 7: EseguiMetodoSpeciale(); break;
                }

            } while (scelta != 0);
        }

        static void AggiungiCorsoMusica()
        {
            Console.Write("Nome corso: ");
            string nome = Console.ReadLine();

            Console.Write("Durata ore: ");
            int durata = int.Parse(Console.ReadLine());

            Console.Write("Docente: ");
            string docente = Console.ReadLine();

            Console.Write("Strumento: ");
            string strumento = Console.ReadLine();

            corsi.Add(new CorsoMusica(nome, durata, docente, strumento));
        }

        static void AggiungiCorsoPittura()
        {
            Console.Write("Nome corso: ");
            string nome = Console.ReadLine();

            Console.Write("Durata ore: ");
            int durata = int.Parse(Console.ReadLine());

            Console.Write("Docente: ");
            string docente = Console.ReadLine();

            Console.Write("Tecnica: ");
            string tecnica = Console.ReadLine();

            corsi.Add(new CorsoPittura(nome, durata, docente, tecnica));
        }

        static void AggiungiCorsoDanza()
        {
            Console.Write("Nome corso: ");
            string nome = Console.ReadLine();

            Console.Write("Durata ore: ");
            int durata = int.Parse(Console.ReadLine());

            Console.Write("Docente: ");
            string docente = Console.ReadLine();

            Console.Write("Stile: ");
            string stile = Console.ReadLine();

            corsi.Add(new CorsoDanza(nome, durata, docente, stile));
        }

        static void VisualizzaCorsi()
        {
            if (corsi.Count == 0)
            {
                Console.WriteLine("Nessun corso presente.");
                return;
            }

            for (int i = 0; i < corsi.Count; i++)
            {
                Console.WriteLine("[" + i + "] " + corsi[i]);
            }
        }

        static void AggiungiStudente()
        {
            VisualizzaCorsi();
            Console.Write("Seleziona indice corso: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < corsi.Count)
            {
                Console.Write("Nome studente: ");
                string nomeStudente = Console.ReadLine();
                corsi[indice].AggiungiStudente(nomeStudente);
            }
            else
            {
                Console.WriteLine("Indice non valido.");
            }
        }

        static void CercaPerDocente()
        {
            Console.Write("Inserisci nome docente: ");
            string docente = Console.ReadLine();

            var risultati = corsi.Where(c => c.Docente.ToLower() == docente.ToLower());

            foreach (var corso in risultati)
            {
                Console.WriteLine(corso);
            }
        }

        static void EseguiMetodoSpeciale()
        {
            VisualizzaCorsi();
            Console.Write("Seleziona indice corso: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < corsi.Count)
            {
                corsi[indice].MetodoSpeciale();
            }
            else
            {
                Console.WriteLine("Indice non valido.");
            }
        }
    }
}