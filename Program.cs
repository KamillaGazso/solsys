using osztaly;
using System.Globalization;

namespace solsys
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            List<osztalyos> bolygo = new List<osztalyos>();

            foreach (var i in File.ReadAllLines(@"../../../src/solsys.txt"))
            {
                bolygo.Add(new osztalyos(i));
            }

            //bolygok szama
            int osszbolygo = 0;
            for (int j = 0; j < bolygo.Count; j++)
            {
                osszbolygo++;
            }
            Console.WriteLine($"Ennyi bolygó adata van a listában:{osszbolygo}");

            //bolygók átlagos holdja
            double atlaghoz = 0;
            int ossz = 0;
            for (int j = 0; j < bolygo.Count; j++)
            {
                atlaghoz += bolygo[j].HoldakSzama;
                ossz++;
            }
            double szam = atlaghoz / ossz;
            Console.WriteLine($"Ennyi a bolygók átlagos holdjának száma:{szam}");

            //legnagyobb terfogatu bolygo
            double max = 0;
            string nev = string.Empty;
            for (int j = 0; j < bolygo.Count; j++)
            {
                if (bolygo[j].TerfogatAranya>max)
                {
                    max = bolygo[j].TerfogatAranya;
                }
                if (bolygo[j].TerfogatAranya==max)
                {
                    nev = bolygo[j].BolygoNeve;
                }
            }
            Console.WriteLine($"A maximum térfogatú bolygó neve:{nev}");

            //bolygo neve
            Console.Write("Írd be annak a bolygónak a nevét, amit keresel:");
            string adottnev = Console.ReadLine();
            for (int i = 0; i < bolygo.Count; i++)
            {
                if (bolygo[i].BolygoNeve.ToLower() == adottnev.ToLower())
                {
                    Console.WriteLine($"Van ilyen nevű bolygó: {bolygo[i].BolygoNeve}");
                }
            }

            //tobb holdja van
            Console.Write("Adj meg egy számot:");
            int adott= Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i < bolygo.Count; i++)
            {
                if (bolygo[i].HoldakSzama>adott)
                {
                    Console.WriteLine($"Ennél több holdja van: {bolygo[i].BolygoNeve}");
                }
            }
        }
    }
}