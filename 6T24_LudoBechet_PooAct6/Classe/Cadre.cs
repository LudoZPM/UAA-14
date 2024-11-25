using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Cadre : Employe
    {
        private int _indice;
         public Cadre(int indice,double matricule, string nom, string prenom, double naissance) : base(matricule, nom, prenom, naissance)
        {
            _indice = indice;
        }
        public int indice 
        { 
            get { return _indice; }
            set { _indice = value; }
        }
        
    }
}
