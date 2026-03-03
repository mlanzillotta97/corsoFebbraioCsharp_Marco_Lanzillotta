using System;

namespace ScuolaArtistica
{
    public class CorsoMusica : Corso
    {
        public string Strumento;

        public CorsoMusica(string nome, int durata, string docente, string strumento)
            : base(nome, durata, docente)
        {
            Strumento = strumento;
        }

        public override void MetodoSpeciale()
        {
            Console.WriteLine("Si tiene una prova pratica dello strumento: " + Strumento);
        }

        public override string ToString()
        {
            return base.ToString() + " | Strumento: " + Strumento;
        }
    }
}