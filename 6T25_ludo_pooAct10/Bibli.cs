using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_ludo_pooAct10
{
    internal class Bibli
    {
        private List<Livre> _livres;
        
        
        public List<Livre> Livres {
            get { return _livres; } 

        }
        public Bibli()
        {
            _livres = new List<Livre>();
        }
        public void Ajoute(Livre livre)
        {
            _livres.Add(livre);
        }
        public void Supprime()
        {
            for (int i = 0; i < _livres.Count; i++)
            {
                if (_livres[i].Etat == 0)
                {
                    _livres.RemoveAt(i);
                }
                
            }
        }
        public string Inventaire()
        {
            string info = "";
            for (int i = 0; i < _livres.Count; i++)
            {
                info += "Auteur: " + Livres[i].Auteur + "\nTitre: " + Livres[i].Titre + "\nEtat: " + Livres[i].Etat + " ";
            }
            return info;
        }
    }
}
