using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Directeur : Employe
    {
        private double _affaire;
        private decimal _pourcentage;
        public Directeur(double affaire, decimal pourcentage, double matricule, string nom, string prenom, double naissance) : base(matricule, nom, prenom, naissance)
        {
            _affaire = affaire;
            _pourcentage = pourcentage;
        }
        public double Affaire 
        { 
            get { return _affaire; } 
            set { _affaire = value; } 
        }
        public decimal Pourcentage 
        { 
            get { return _pourcentage; }
            set { _pourcentage = value; } 
        }
    }
}
