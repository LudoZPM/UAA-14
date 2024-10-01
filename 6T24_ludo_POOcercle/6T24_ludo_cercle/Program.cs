using _6T24_ludo_cercle.Class;

namespace _6T24_ludo_cercle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double rayon;
            String reapetProg;

            do
            {


                Console.WriteLine("entrez le rayon");
                rayon = Double.Parse(Console.ReadLine());
                Cercle cercle = new Cercle(rayon);

                Console.WriteLine("air : " + cercle.CalculeAir());
                Console.WriteLine("perimetre : " + cercle.CalculePerimetre());



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