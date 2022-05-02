namespace SpeditionLibrary
{
    public class Corriere
    {
        private readonly string NomeCorriere;
        public List<Spedizione> corriereList;

        public Corriere(string nomeCorriere)
        {
            NomeCorriere = nomeCorriere;
            corriereList = new List<Spedizione>();
        }

        public void PrintSpedizioni()
        {
            double ingombroTot = 0;
            Console.WriteLine($"Corriere: {NomeCorriere}");
            Console.WriteLine("\n---------- Riepilogo Spedizioni ----------\n");

            foreach (var s in corriereList)
            {
                Console.WriteLine($"Mittente: {s.Mittente}\n" +
                    $"Destinatario: {s.Destinatario}\n" +
                    $"Ingombro: {s.getIngombro()}\n" +
                    $"-----------------------------");
                ingombroTot +=  s.getIngombro();
            }

            Console.WriteLine($"Ingombro TOT: {ingombroTot}");
         
        }
    }
}
