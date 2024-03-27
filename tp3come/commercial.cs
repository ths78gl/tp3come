using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_commercial
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;
        private Categorie categorie;
        private Service Service;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        internal Categorie Categorie { get => categorie; set => categorie = value; }
        internal Service Service1 { get => Service; set => Service = value; }

        public Commercial(string nom, string prenom, int anneeNaissance, Categorie  categorie)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance;
            this.Categorie = categorie;
        }
        public int CalculAge()
        {
            int age = DateTime.Now.Year - this.anneeNaissance;
            return age;
        }
        public override string ToString()
        {
            
            return $"Infos du commercial : {Categorie}";
        }
        public string Compare(Commercial c)
        {
            if (this.Nom == c.Nom)
            {
                return "Les deux commerciaux ont le même nom de famille.";
            }
            else
            {
                return "Les deux commerciaux n'ont pas le même nom de famille.";
            }
        }
        // Propriété pour stocker le service auquel appartient le commercial
        

        // Constructeur pour in le service
        public Commercial(Service service)
        {
            Service1 = service;
            
            service.AjouterCom(this);
        }

        
    }
}

   



