using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    abstract class  Parallelepipede
    {

        private string _couleur;


        public Parallelepipede(string couleur)
        {
            _couleur = couleur;
        }


        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }


        public abstract string CalculePerimetre();


        public abstract string CalculeSurface();
    }

}

