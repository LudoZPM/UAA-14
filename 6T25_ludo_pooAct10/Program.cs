namespace _6T25_ludo_pooAct10
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string nUser;
            string nUser1;
            string nUser2;
            string Reco;
            string reapetProg;

            Console.WriteLine("livre de la bibliothèque :");

            Bibli bibliotheque = new Bibli();

            Livre livre = new Livre("kk le grand magicien", "Elprout", 5);
            Console.WriteLine(livre.Description());
            bibliotheque.Ajoute(livre);

            Livre livre1 = new Livre("L ane alcoolique", "Twitch.tv/vintagiix", 5);
            Console.WriteLine(livre1.Description());
            bibliotheque.Ajoute(livre1);

            Livre livre2 = new Livre("Les chronique Andras portal", "Aperture Science", 5);
            Console.WriteLine(livre2.Description());
            bibliotheque.Ajoute(livre2);

            Console.WriteLine("Que voulez faire \n1)Afficher l inventaire\n2)Degrader un livre");
            nUser = Console.ReadLine();

            if (nUser == "1")
            {
                Console.WriteLine("Inventaire");
                Console.WriteLine("------------------");
                bibliotheque.Inventaire();
                Console.WriteLine(bibliotheque.Inventaire());

            }
            if (nUser == "2")
            {
                Console.WriteLine("Supprimer");
                Console.WriteLine("------------------");
                Console.WriteLine("Quelle livre voulez-vous supprimer");
                nUser1 = Console.ReadLine();
                bibliotheque.Supprime();
                Console.WriteLine("Marche pas");
            }
            if (nUser == "2")
            {
                Console.WriteLine("Degrader");
                Console.WriteLine("------------------");

                do
                {
                    Console.WriteLine("Quel livre voulez-vous degrader : livre 1, 2 ou 3");
                    nUser2 = Console.ReadLine();
                    if (nUser2 == "1")
                    {
                        bibliotheque.Livres[0].Degrade();
                    }
                    if (nUser2 == "2")
                    {
                        bibliotheque.Livres[1].Degrade();
                    }
                    if (nUser2 == "3")
                    {
                        bibliotheque.Livres[2].Degrade();
                    }
                    bibliotheque.Supprime();
                    Console.WriteLine(bibliotheque.Inventaire());

                    Console.WriteLine("Voulez-vous recommencer ? 'espace'");
                    reapetProg = Console.ReadLine();
                } while (reapetProg == " ");




            }



        }
    }
}