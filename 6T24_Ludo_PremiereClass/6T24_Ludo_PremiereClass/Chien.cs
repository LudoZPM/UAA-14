using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_Ludo_PremiereClass
{
    internal class Chien
    {
        private string _race;
        private string _nom;
        private bool _puce;
        private double _taille;
        private double _poids;
        private string _etat;
        private int _age;

        public Chien(string race, string nom, double taille, double poids, string etat, int age)
        {
            _race = race;
            _nom = nom;
            _puce = true;
            _taille = taille;
            _poids = poids;
            _etat = etat;
            _age = age;
        }
        public string Manger()
        {
            return "Miam-trop bon";
        }
        public string InfosChien()
        {
            return "Le chien " + _nom + " ,est de race " + _race + " ,Il a une taille de " + _taille + " cm, il a un poids de " + _poids + " kg, il est :" + _etat + " et ,il a " + _age + " ans";
        }
        public string NamesChien()
        {
            return _nom;
        }
        public string raceChien()
        {
            return _race;
        }
        public double tailleChien()
        {
            return _taille;
        }
        public double poidsChien()
        {
            return _poids;
        }
        public string etatChien()
        {
            return _etat;
        }
        public int ageChien()
        {
            return _age;
        }
        

    }
}
