
namespace SpeditionLibrary
{
    public abstract class Spedizione
    {
        public string Mittente { get; }
        public string Destinatario { get; }
        public double Valore { get; set; }

        public Spedizione(string mittente, string destinatario)
        {
            Mittente = mittente;
            Destinatario = destinatario;
        }

        public double printIngombro()
        {
            return getIngombro();
        }

        public bool Equals(Object obj)
        {
            return obj is Spedizione sped && 
                Mittente == sped.Mittente &&
                Destinatario == sped.Destinatario &&
                Valore == sped.Valore &&
                getIngombro() == sped.getIngombro();
        }

        public abstract double getIngombro();
    }
}
