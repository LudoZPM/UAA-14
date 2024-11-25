using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Boat : Car
    {
        private double _tonnage;
        public Boat(double tonnage, string marque, string fuel, double kilo) : base(marque, fuel, kilo)
        {
            _tonnage = tonnage;
        }
        public double tonnage 
        { 
            get { return _tonnage; } 
            set { _tonnage = value; } 
        }
        public override string Info()
        {
            return "\nLe tonnage max est de : " + _tonnage;
        }
    }
}
