namespace ObserverUtenti
{
    class Utente
    {
        public string Nome { get; set; }

        public Utente(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return "Utente creato: " + Nome;
        }
    }
}