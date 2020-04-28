using System;
using System.Collections.Generic;
using System.Text;

namespace Arborescence
{
    public abstract class Element
    {
        private string Nom { get; }
        private long Taille { get; }

        protected Element(string nom, long taille)
        {
            Nom = nom;
            Taille = taille;
        }
    }
}
