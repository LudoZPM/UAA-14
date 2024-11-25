using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;

        public Velo(string type, bool electrique, string marque, string modele, string couleur, decimal prix) : base(marque, modele, couleur, prix)
        { 

            _type = type;
            _estElectrique = estElectrique;

        }   

        public string type
        {
            get { return _type; } 
            set { _type = value; }

        } 
        public bool estElectrique
        {
            get { return _estElectrique; }
            set { _estElectrique = value;}
        }

        public override string Info()
        {
            return "Le velo est de type" + _type + "est il est " + _estElectrique;
        }
            
    }
}
