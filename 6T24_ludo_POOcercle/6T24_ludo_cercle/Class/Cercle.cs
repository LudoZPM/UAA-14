using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_ludo_cercle.Class
{
    internal class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {

            _rayon = rayon;
        }
        public double CalculeAir()
        {
            double CalculeAir = Math.PI * Math.Sqrt(_rayon);
            return CalculeAir;

        }
        public double CalculePerimetre()
        {
            double CalculePerimetre = Math.PI * _rayon * 2;
            return CalculePerimetre;
        }
        public string InfoCercle()
        {
            return "Le cercle a un rayon " + _rayon + " a un perimetre de " + CalculePerimetre() + " ";
        }







    }






}
