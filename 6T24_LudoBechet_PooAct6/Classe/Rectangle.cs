using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Rectangle : Parallelepipede
    {
        private double _longueur;
        private double _largeur;

        public Rectangle(string couleur,double longueur, double largeur) : base(couleur)
        {
            _longueur = longueur;
            _largeur = largeur;
        }
        public double longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }
        public double largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        public override string CalculePerimetre()
        {
            return "Le prerimetre est de " + (_longueur * _largeur) * 2;
        }
        public override string CalculeSurface()
        {
            return "La surface de ce rectangle est " + _longueur * _largeur;
        }

    }
}
