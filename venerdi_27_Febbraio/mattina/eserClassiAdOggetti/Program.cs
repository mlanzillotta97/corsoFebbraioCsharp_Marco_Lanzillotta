using System;

namespace EserciziCompleti
{
    class Program
    {
        static void Main(string[] args)
        {
            EsercizioStudente();
            Console.WriteLine("\n-------------------\n");

            EsercizioPersona();
            Console.WriteLine("\n-------------------\n");

            EsercizioOperazioni();
        }

        static void EsercizioStudente()
        {
            Studente s1 = new Studente();
            Studente s2 = new Studente();

            s1.Nome = "Marco";
            s1.Matricola = 1001;
            s1.MediaVoti = 27.5;

            s2.Nome = "Laura";
            s2.Matricola = 1002;
            s2.MediaVoti = 29.2;

            Console.WriteLine("=== ESERCIZIO STUDENTE ===");
            Console.WriteLine(s1.Nome + " - Matricola: " + s1.Matricola + " - Media: " + s1.MediaVoti);
            Console.WriteLine(s2.Nome + " - Matricola: " + s2.Matricola + " - Media: " + s2.MediaVoti);
        }

        static void EsercizioPersona()
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            p1.Nome = "Luca";
            p1.Cognome = "Rossi";
            p1.AnnoNascita = 1998;

            p2.Nome = "Giulia";
            p2.Cognome = "Bianchi";
            p2.AnnoNascita = 2000;

            Console.WriteLine("=== ESERCIZIO PERSONA ===");
            Console.WriteLine(p1.Nome + " " + p1.Cognome + " è nato nel " + p1.AnnoNascita);
            Console.WriteLine(p2.Nome + " " + p2.Cognome + " è nato nel " + p2.AnnoNascita);
        }

        static void EsercizioOperazioni()
        {
            Operazioni op = new Operazioni();

            Console.WriteLine("=== ESERCIZIO OPERAZIONI ===");

            Console.Write("Inserisci il primo numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Inserisci il secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            int somma = op.Somma(n1, n2);
            int prodotto = op.Moltiplica(n1, n2);

            op.StampaRisultato("Somma", somma);
            op.StampaRisultato("Moltiplicazione", prodotto);
        }
    }
}