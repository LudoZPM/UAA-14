using System.Diagnostics;

namespace _6TI_Ludo_TryParseExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeatProg;

            do
            {
                
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----TryParse rappel----");

            Console.WriteLine("Entrez la suite de chiffres '123' ");
            string texte = Console.ReadLine(); 

            int nombre;
            bool tryparse = int.TryParse(texte, out nombre); 

            if (tryparse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vous avez entré la suite de chiffres demandée.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vous n'avez pas entré la suite de chiffres demandée.");
            }

                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();

            } while (repeatProg =="o");
            
            

        }
    }
}
