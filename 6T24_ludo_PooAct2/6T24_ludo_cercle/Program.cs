using _6T24_ludo_cercle.Class;

namespace _6T24_ludo_cercle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double rayon;
            String reapetProg;
            string nUser;

            do
            {

                Console.WriteLine("Entrez ce que vous voulez faire (1: cercle, 2: nombre premier, 3: sandwitch)");
                nUser = Console.ReadLine();

                if (nUser == "1")
                {
                    Console.WriteLine("entrez le rayon (cm)");
                    rayon = Double.Parse(Console.ReadLine());
                    Cercle cercle = new Cercle(rayon);

                    Console.WriteLine("air : " + cercle.CalculeAir());
                    Console.WriteLine("perimetre : " + cercle.CalculePerimetre());
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Avec un cercle de rayon  de moitié :");
                    Cercle cercle2 = new Cercle(rayon / 2);
                    //Console.WriteLine("Le cercle de rayon " + cercle2.rayon() + ", a un périmètre de " + cercle2.CalculePerimetre() + " et une aire de " + cercle2.CalculeAir());

                }
                if (nUser == "2")
                {
                    Console.WriteLine("Entrez la valur du premier nombre réelle de départ");
                    Console.WriteLine("Entrez la valur du premier nombre imaginaire de départ");
                    Console.WriteLine("Entrez la valur du second nombre réelle de départ");
                    Console.WriteLine("Entrez la valur du second nombre imaginaire de départ");

                }
                if(nUser == "3")
                {

                }



                



                Console.WriteLine("voulez vous reco (espace)");
                reapetProg = Console.ReadLine();
            } while (reapetProg == " ");

            
            
            //for (uint i = 0; i < cercle.Length; i++)
            //{
                //cercle[i] = new Cercle(i, i);
                //Console.WriteLine(cercle[i].CalculePerimetre();

            //}
        }
    }
}