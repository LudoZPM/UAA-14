using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Lapin : Animaux
    {
        private decimal _oreille;

        public Lapin(decimal oreille, string nom, decimal naissance, double puce, double taille, bool concoure) : base(nom, naissance, puce, taille, concoure)
        {
            _oreille = oreille;

        }
        private decimal Oreille
        {
            get { return _oreille; }
            set { _oreille = value; }
        }

        public override string Info()
        {
            return "Les oreille du lapin sont d'un hauteur de :" + _oreille;
        }
    }
}
