using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Animaux
    {
        private string _nom;
        private decimal _naissance;
        private double _puce;
        private double _taille;
        private bool _concoure;

        public Animaux(string nom, decimal naissance, double puce, double taille, bool concoure)
        {
            _nom = nom;
            _naissance = naissance;
            _puce = puce;
            _taille = taille;
            _concoure = concoure;
        }
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public decimal naissance
        {
            get { return _naissance; }
            set {  _naissance = value; }
        }
        public double puce
        {
            get { return _puce; }
            set { _puce = value; }
        }
        public double taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        public bool concoure
        {
            get { return _concoure; }
            set { _concoure = value; }
        }
        public virtual string Info()
        {
            return "Le nom du chien est " + nom + " il est né le " + naissance + " le numero de la puce est " + _puce + " ça taille est " + _taille + "et il participe ou non au concoure" + _concoure;
        }
        
        
    }
}
