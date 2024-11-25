using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(marque, modele, couleur, prix)

        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public string motorisation
        {
            get { return _motorisation; }
            set { _motorisation = value; }
        }

        public bool gps
        {
            get { return _gps; }
            set { _gps = value; }
        }
        public override string Info()
        {
            return "La motorisation de la voiture est " + _motorisation + " est elle a " + _gps;
        }

    }
}
