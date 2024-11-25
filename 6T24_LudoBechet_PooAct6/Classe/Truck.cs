using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Truck : Car
    {
        private double _poids;

        public Truck(double poids, string marque, string fuel, double kilo): base(marque, fuel, kilo)
        {
            _poids = poids;
        }
        public double poids 
        {  
            get { return _poids; } 
            set {  _poids = value; } 
        }

        public override string Info()
        {
            return "\nLe poids max est de :" + _poids ;
        }

    }
}
