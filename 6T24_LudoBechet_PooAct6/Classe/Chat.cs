using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T24_LudoBechet_PooAct6.Classe
{
    internal class Chat : Animaux
    {
        public Chat(string nom, decimal naissance, double puce, double taille, bool concoure) : base(nom, naissance, puce, taille, concoure)
        {


        }

        public override string Info()
        {
            return "le chat miaule, le chat ronrone";
        }
    }
}
