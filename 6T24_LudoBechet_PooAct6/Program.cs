using _6T24_LudoBechet_PooAct6.Classe;

namespace _6T24_LudoBechet_PooAct6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nUser;
            string reapet;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choisissez l'exercice : 1 = véhicule, 2 = animaux, 3 = géométrie, 4 = gestion des employés, 5 = entreprise de véhicule");
                nUser = Console.ReadLine();

                if (nUser == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez choisi les véhicules");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("Voiture(1) ou vélo(2)");
                        nUser = Console.ReadLine();

                        if (nUser == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Voiture");
                            Console.ForegroundColor = ConsoleColor.White;
                            Vehicule vehicule = new Vehicule("308", "Peugeot", "Bleu", 21000);
                            Console.WriteLine(vehicule.Info());
                        }
                        else if (nUser == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Vélo");
                            Console.ForegroundColor = ConsoleColor.White;
                            Velo velo = new Velo("VTT", true, "B-win", "3", "rouge", 360);
                            Console.WriteLine(velo.Info());
                        }

                        Console.WriteLine("Recommencer ? oui = 'espace'");
                        reapet = Console.ReadLine();
                    } while (reapet == " ");
                }
                else if (nUser == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez choisi les animaux");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("Chien(1), Chat(2) ou Lapin(3)");
                        nUser = Console.ReadLine();

                        if (nUser == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Chien");
                            Console.ForegroundColor = ConsoleColor.White;
                            Chien chien = new Chien("FloconLePlusBo", 24092018, 20, 1003040150, false);
                            Console.WriteLine(chien.Info());
                        }
                        else if (nUser == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Chat");
                            Console.ForegroundColor = ConsoleColor.White;
                            Chat chat = new Chat("Caline", 01122006, 034509, 30, false);
                            Console.WriteLine(chat.Info());
                        }
                        else if (nUser == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Lapin");
                            Console.ForegroundColor = ConsoleColor.White;
                            Lapin lapin = new Lapin(01, "Jean Didier de la Rochelle", 11092001, 20938748, 12, false);
                            Console.WriteLine(lapin.Info());
                        }

                        Console.WriteLine("Recommencer ? oui = 'espace'");
                        reapet = Console.ReadLine();
                    } while (reapet == " ");
                }
                else if (nUser == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez choisi la géométrie");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("Rectangle(1) ou Carré(2)");
                        nUser = Console.ReadLine();

                        if (nUser == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rectangle");
                            Console.ForegroundColor = ConsoleColor.White;
                            Rectangle rectangle = new Rectangle("Jaune", 5, 6);
                            Console.WriteLine(rectangle.CalculePerimetre());
                            Console.WriteLine(rectangle.CalculeSurface());
                        }
                        else if (nUser == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Carré");
                            Console.ForegroundColor = ConsoleColor.White;
                            Carre carre = new Carre("Rouge", 4);
                            Console.WriteLine(carre.CalculePerimetre());
                            Console.WriteLine(carre.CalculeSurface());
                        }

                        Console.WriteLine("Recommencer ? oui = 'espace'");
                        reapet = Console.ReadLine();
                    } while (reapet == " ");
                }
                if (nUser == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez choisi la gestion des employés");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("Employé(1), Ouvrier(2), Cadre(3), Directeur(4)");
                        nUser = Console.ReadLine();

                        if (nUser == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Employé");
                            Console.ForegroundColor = ConsoleColor.White;
                            Employe employe = new Employe(01263548901, "Bechet", "Ludo", 15102007);
                            Console.WriteLine(employe.Info());
                        }
                        else if (nUser == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ouvrier");
                            Console.ForegroundColor = ConsoleColor.White;
                            Ouvrier ouvrier = new Ouvrier(01122007, 1200, 0238823, "Jean", "Castex", 24120000);
                            Console.WriteLine(ouvrier.Info());
                        }
                        else if (nUser == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Cadre");
                            Console.ForegroundColor = ConsoleColor.White;
                            Cadre cadre = new Cadre(2, 29302849, "Dior", "Patrick", 01051987);
                            Console.WriteLine(cadre.Info());
                        }
                        else if (nUser == "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Directeur");
                            Console.ForegroundColor = ConsoleColor.White;
                            Directeur directeur = new Directeur(12, 23, 237808203, "De Rivebois", "Ralof", 11112011);
                            Console.WriteLine(directeur.Info());
                        }

                        Console.WriteLine("Recommencer ? oui = 'espace'");
                        reapet = Console.ReadLine();
                    } while (reapet == " ");
                }
                if(nUser == "5")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez choisi l'entreprise de véhicule");
                    Console.ForegroundColor = ConsoleColor.White;

                    do
                    {
                        Console.WriteLine("Voiture(1), Truck(2), Bateau(3), Avion(4), Véhicule de route(5), Véhicule(6)");
                        nUser = Console.ReadLine();
                        if(nUser == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Voiture");
                            Console.ForegroundColor = ConsoleColor.White;
                            Car car = new Car("Audi", "Plein", 1254637);
                            Console.WriteLine(car.Info());
                        }
                        if(nUser == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Truck");
                            Console.ForegroundColor = ConsoleColor.White;
                            Truck truck = new Truck(2000, "^rout", "vide", 123242);
                            Console.WriteLine(truck.Info());
                        }
                        if (nUser == "3")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bateau");
                            Console.ForegroundColor = ConsoleColor.White;
                            Boat boat = new Boat(200, "eau", "Plein", 1923809 );
                            Console.WriteLine(boat.Info());
                        }
                        if (nUser == "4")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Avion");
                            Console.ForegroundColor = ConsoleColor.White;
                            Plane plane = new Plane(27635, "air", "vide", 9238);
                            Console.WriteLine(plane.Info());
                        }
                        if (nUser == "5")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Véhicule de route");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (nUser == "6")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Véhicule");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.WriteLine("Recommencer ? oui = 'espace'");
                        reapet = Console.ReadLine();
                    } while (reapet == " ");
                }

                Console.WriteLine("Retourner au menu principal ? oui = 'espace'");
                reapet = Console.ReadLine();
            } while (reapet == " ");
        }
    }
}
