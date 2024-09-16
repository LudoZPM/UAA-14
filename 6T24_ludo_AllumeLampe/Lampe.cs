using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_ludo_AllumLampe
{
    internal class Interrupteur
    {
        private string _couleur;
        private bool _etat;
        private string _type;

        public Interrupteur(string couleur, string etat, string type)
        {
            _couleur = couleur;
            _etat = true;
            _type = type;
        }
        public string CouleurInterrupteur()
        {
            return _couleur;
        }
        public bool EtatInterrupteur()
        {
            return _etat;
        }
        public string TypeInterrupteur()
        {
            return _type;
        }
        public string InfosInterrupteur()
        {
            return " l'interrupteur est de couleur " + _couleur + " , il est de  type" + _type + "." ;
        }
    }
    internal class Lampe
    {
        private string _couleur;
        private string _typeAmpoule;
        private double _puissance;

        public Lampe(string couleur, string typeAmpoule, double puissance)
        {
            _couleur = couleur;
            _typeAmpoule = typeAmpoule;
            _puissance = puissance;
        }
        public string CouleurLampe()
        {
            return _couleur;
        }
        public string TypeAmpoule() 
        { 
            return _typeAmpoule;
        }
        public double PuissanceLampe()
        {
            return _puissance;
        }
        public string InfosLampe()
        {
            return "La lampe est de couleur " + _couleur + " elle a une ampoule de type " + _typeAmpoule + " et elle a une puissance de " + _puissance + "W.";
        }
    }
}
