using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_ludo_pooAct10
{
    internal class Livre
    {
        private string _titre;
        private string _auteur;
        private byte _etat;

        public Livre(string titre, string auteur, byte etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }
        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        public byte Etat
        {
            get { return _etat; }
            set
            {
                if (value > 0 && value < 5)
                {
                    _etat += value;
                }
                else
                {
                    _etat += 5;
                }
            }
        }
        public void Degrade()
        {
            if (_etat > 0)
            {
                _etat--;
            }
            else if (_etat == 0)
            {
                string infos = "le livre est trop abime et doit etre changer";
            }


        }
        public string Description()
        {
            return "Le titre du livre est: " + Titre + "\nL'auteur est: " + Auteur + "\nL'etat est: " + Etat + "\n-----------------";
        }
    }
}

