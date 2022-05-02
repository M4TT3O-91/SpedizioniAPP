namespace SpeditionLibrary.Entities
{
    public class Plico : Spedizione
    {
        public Plico(string mittente, string destinatario) : base(mittente, destinatario)
        {
        }

        public double Altezza { get; set; }
        public double Larghezza { get; set; }
        


        public override double getIngombro()
        {
            return Larghezza * Altezza;
        }

    }
}
