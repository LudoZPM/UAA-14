using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Ouvrier : Employe
    {
        private double _entrer;
        private double _salaire;

        public Ouvrier(double entrer, double salaire,double matricule, string nom, string prenom, double naissance) : base(matricule, nom, prenom, naissance)
        {
            _entrer = entrer;
            _salaire = salaire;
        }
        public double entrer {  

            get { return _entrer; } 
            set {  _entrer = value; } 
        }
        public double salire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }
        
        
    }
}
