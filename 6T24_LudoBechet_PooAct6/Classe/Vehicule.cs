using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Vehicule
    {
        private string _modele;
        private string _marque;
        private string _couleur;
        private decimal _prix;

        public Vehicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }
        public string modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
        public string marque
        {
            get { return _marque; }
            set { _marque = value; }
        }
        public string couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public decimal prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public virtual string Info()
        {
            return "Le modele du vehicule est " + _modele + " la marque est " + _marque + " la couleur est " + _couleur + " et le prix est " + _prix;
        }




    }
}
