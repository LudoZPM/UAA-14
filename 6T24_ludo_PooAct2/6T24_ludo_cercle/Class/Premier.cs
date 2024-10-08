using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_ludo_cercle.Class
{
    internal class Premier
    {
        private double _reelle;
        private double _imaginaire;

        public Premier(double reelle, double imaginaire)
        {
            _reelle = reelle;
            _imaginaire = imaginaire;
            
        }
        
        public string AfficheComplexe()
        {
            string afficheComplexe = "(" + _imaginaire + "," + _reelle + " ) " ;
            return afficheComplexe;
        }
        public double CalculeModule()
        {
            double CalculeModule = Math.Sqrt(Math.Pow(_reelle, 2)+ Math.Pow(_imaginaire, 2));
            return CalculeModule;
        }
        public void Ajoute(Complex complexe)
        {
            
        }

    }
    

}
