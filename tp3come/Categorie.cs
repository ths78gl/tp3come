using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_commercial
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }
        public Categorie(string codeCategorie, string libCategorie)
    
        {
            this.codeCategorie=codeCategorie;
            this.libCategorie=libCategorie;
        }

        public override string ToString()
        {
            return $"codeCategorie: {codeCategorie}, libCategorie: {libCategorie}";
        }
    }
}
