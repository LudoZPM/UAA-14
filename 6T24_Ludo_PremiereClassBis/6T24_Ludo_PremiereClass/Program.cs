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
            Console.WriteLine(monPremierChien.Nom + monPremierChien.Race);

            for (uint i = 0; i < chiens.Length; i++)
            {
                chiens[i] = new Chien ("race", "nom", i,i, "etat", i) ;
                Console.WriteLine(chiens[i].Nom + " " + chiens[i].Race + " " + chiens[i].Taille + " " + chiens[i].Poids + " " + chiens[i].Etat + " " + chiens[i].Age);

            }

            


        }
    }
}