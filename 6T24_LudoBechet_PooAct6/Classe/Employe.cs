using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Employe
    {
        private double _matricule;
        private string _nom;
        private string _prenom;
        private double _naissance;

        public Employe(double matricule, string nom, string prenom, double naissance)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _naissance = naissance;
        }
        public double maticule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public double naissance
        {
            get { return _naissance; }
            set { _naissance = value; }
        }
        public virtual string Info()
        {
            return "Matricule : " + _matricule + "\nNom : " + _nom + "\nPrenom : " + _prenom + "\nNaissance : " + _naissance;
        }
        
    }
}
