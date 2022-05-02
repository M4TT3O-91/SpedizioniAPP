
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

        public override bool Equals(Object obj)
        {
            return obj is Spedizione sped && 
                Mittente == sped.Mittente &&
                Destinatario == sped.Destinatario &&
                Valore == sped.Valore &&
                getIngombro() == sped.getIngombro();
        }

        public override string? ToString()
        {
            return $"Mitt: {Mittente} -> Dest: {Destinatario} - Valore:{Valore} - {getIngombro()}";
        }

        public abstract double getIngombro();

        public override int GetHashCode()
        {
            return HashCode.Combine(Mittente, Destinatario, Valore, getIngombro());
        }
    }
}
