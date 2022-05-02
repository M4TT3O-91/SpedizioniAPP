using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeditionLibrary
{
    public class Corriere
    {
        public string NomeCorriere { get; }
        public List<Spedizione> corriereList;

        public Corriere(string nomeCorriere)
        {
            NomeCorriere = nomeCorriere;
            corriereList = new List<Spedizione>();
        }

        public void PrintSpedizioni()
        {
            double ingombroTot = 0;
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
