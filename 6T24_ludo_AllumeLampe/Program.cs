namespace _6T24_ludo_AllumLampe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Lampe et ampoule---");

            //Lampe maLampe = new Lampe("bleu","led", 20);
            // Console.WriteLine(maLampe.InfosLampe());
            Lampe[] lampes = new Lampe[5];
            Interrupteur[] interrupteurs = new Interrupteur[5];
            //Console.WriteLine(maLampe.CouleurLampe() + maLampe.TypeAmpoule() + maLampe.PuissanceLampe());

            for (int i = 0; i < lampes.Length; i++) 
            {
                lampes[i] = new Lampe("couleur", "type", i);
                Console.WriteLine(lampes[i].CouleurLampe() + " " + lampes[i].TypeAmpoule() + " " + lampes[i].PuissanceLampe());
            }
            
            for (int i = 0; i < interrupteurs.Length; i++) // Correction ici
            {
                interrupteurs[i] = new Interrupteur("couleur", "etat", "type");
                Console.WriteLine(interrupteurs[i].CouleurInterrupteur() + " " + interrupteurs[i].EtatInterrupteur() + " " + interrupteurs[i].TypeInterrupteur());
            }
        }
    }

}
