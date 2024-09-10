namespace _6T24_Ludo_PremiereClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Chien monPremierChien = new Chien("Bichon", "Flocon", 30 , 6 , "mignon" , 5) ;
            Console.WriteLine(monPremierChien.InfosChien()) ;
            Chien[] chiens = new Chien[10];
            Console.WriteLine(monPremierChien.NamesChien() + monPremierChien.raceChien());

            for (int i = 0; i < chiens.Length; i++)
            {
                chiens[i] = new Chien ("race", "nom", i,i, "etat", i) ;
                Console.WriteLine(chiens[i].NamesChien() + " " + chiens[i].raceChien() + " " + chiens[i].tailleChien() + " " + chiens[i].poidsChien() + " " + chiens[i].etatChien() + " " + chiens[i].ageChien());

            }

            


        }
    }
}