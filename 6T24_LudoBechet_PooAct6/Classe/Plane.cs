using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Plane : Car
    {
        private double _range;
        public Plane(double range, string marque, string fuel, double kilo) : base(marque, fuel, kilo)
        {
            _range = range;
        }
        public double range
        {
            get { return _range; }
            set { _range = value; }
        }
        public override string Info()
        {
            return "\nLa range max est de : " + _range;
        }
    }
}
