using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Car
    {
        private string _marque;
        private string _fuel;
        private double _kilo;

        public Car(string marque, string fuel, double kilo)
        {
            _marque = marque;
            _fuel = fuel;
            _kilo = kilo;
        }
        public string marque 
        { 
            get { return _marque; } 
            set { _marque = value; }
        }
        public string fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public double kilo
        {
            get { return _kilo; }
            set { _kilo = value; }
        }
        
        public virtual string Info()
        {
            return "La marque est : " + _marque + "\nle fuel est : " + _fuel + "\nLe nombre de kilomètre est de :" + _kilo ;
        }

    }
}
