using System;
using System.Collections.Generic;

namespace ScuolaArtistica
{
    public class Corso
    {
        public string NomeCorso;
        public int DurataOre;
        public string Docente;
        public List<string> Studenti;

        public Corso(string nome, int durata, string docente)
        {
            NomeCorso = nome;
            DurataOre = durata;
            Docente = docente;
            Studenti = new List<string>();
        }

        public void AggiungiStudente(string nomeStudente)
        {
            Studenti.Add(nomeStudente);
        }

        public virtual void MetodoSpeciale()
        {
            Console.WriteLine("Metodo speciale generico del corso.");
        }

        public override string ToString()
        {
            return "Corso: " + NomeCorso +
                " | Durata: " + DurataOre + " ore" +
                " | Docente: " + Docente +
                " | Studenti: " + Studenti.Count;
        }
    }
}