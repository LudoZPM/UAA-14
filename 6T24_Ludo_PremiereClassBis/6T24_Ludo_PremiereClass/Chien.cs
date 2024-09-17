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
        private uint _age;

        public Chien(string race, string nom, double taille, double poids, string etat, uint age)
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
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
            
                _nom = value;
                
            }
        }
        public string Race
        {
            get
            {
                return _race;
            }
        }
        public double Taille
        {
            get
            {
                return _taille;
            }
            set
            {
                if (value < 0)
                {
                    _taille = value;
                }
            }
        }
        public double Poids
        {
            get
            {
                return _poids;
            }
            set
            {
                if (value < 0)
                {
                    _poids = value;
                }
            }
        }
        public string Etat
        {
            get
            {
                return _etat;
            }
            set
            {
            
                _etat = value;
                
            }
        }
        public uint Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = value;
                }
            }
        }
        

    }
}
