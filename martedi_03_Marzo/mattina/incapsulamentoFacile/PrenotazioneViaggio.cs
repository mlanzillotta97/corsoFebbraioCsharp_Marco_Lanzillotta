using System;

namespace AgenziaViaggi
{
    public class PrenotazioneViaggio
    {
        private int postiPrenotati;
        private const int maxPosti = 20;

        // Proprietà pubblica Destinazione
        public string Destinazione { get; set; }

        // Proprietà sola lettura PostiDisponibili
        public int PostiDisponibili
        {
            get { return maxPosti - postiPrenotati; }
        }

        // Proprietà sola lettura PostiPrenotati
        public int PostiPrenotati
        {
            get { return postiPrenotati; }
        }

        // Costruttore
        public PrenotazioneViaggio(string destinazione)
        {
            Destinazione = destinazione;
            postiPrenotati = 0;
        }

        // Metodo per prenotare posti
        public void PrenotaPosti(int numero)
        {
            if (numero > 0 && numero <= PostiDisponibili)
            {
                postiPrenotati += numero;
                Console.WriteLine("Prenotati " + numero + " posti per " + Destinazione);
            }
            else
            {
                Console.WriteLine("Prenotazione non valida: posti insufficienti o numero errato.");
            }
        }

        // Metodo per annullare prenotazione
        public void AnnullaPrenotazione(int numero)
        {
            if (numero > 0 && numero <= postiPrenotati)
            {
                postiPrenotati -= numero;
                Console.WriteLine("Annullati " + numero + " posti per " + Destinazione);
            }
            else
            {
                Console.WriteLine("Annullamento non valido: numero errato.");
            }
        }
    }
}