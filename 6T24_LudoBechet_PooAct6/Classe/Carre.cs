using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Carre : Parallelepipede
    {
        private double _cote;

        public Carre (string couleur,double cote) : base(couleur)
        {
            _cote = cote;
        }
        public double cote
        {
            get { return _cote; }
            set { _cote = value; }
        }
        public override string CalculePerimetre()
        {
            return "Le pertimetre est de : " + _cote * 4 ;
        }
        public override string CalculeSurface()
        {
            return "La surface est de  : " + _cote * _cote ;
        }
    }
}
