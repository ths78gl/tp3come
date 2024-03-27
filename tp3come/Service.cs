using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_commercial
{
    internal class Service
    {
        
            private string NomDuService;
            private Commercial[] TableauCom;
            private int Effectif;

            
            public Service(string nomDuService)
            {
                NomDuService1 = nomDuService;
                TableauCom1 = new Commercial[10]; 
                Effectif1 = 0; 
            }

        public string NomDuService1 { get => NomDuService; set => NomDuService = value; }
        public int Effectif1 { get => Effectif; set => Effectif = value; }
        internal Commercial[] TableauCom1 { get => TableauCom; set => TableauCom = value; }

        public string GetNomDuService()
            {
                return NomDuService1;
            }

            public void SetNomDuService(string nom)
            {
                NomDuService1 = nom;
            }
        // Méthode pour ajouter un commercial au tableau
        public void AjouterCom(Commercial c)
        {
            if (Effectif < TableauCom.Length)
            {
                TableauCom[Effectif] = c;
                Effectif++;
                Console.WriteLine($"Commercial ajouté au service {NomDuService}.");
            }
            else
            {
                Console.WriteLine($"Le tableau est plein. Impossible d'ajouter un nouveau commercial au service {NomDuService}.");
            }
        }
        // Méthode pour renvoyer le commercial le plus âgé
        public Commercial TrouverCommercialLePlusAge()
        {
            Commercial commercialLePlusAge = null;
            int ageMax = int.MinValue;

            foreach (Commercial comme in TableauCom)
            {
                int age = CalculAge(comme.AnneeNaissance); 
                if (age > ageMax)
                {
                    ageMax = age;
                    commercialLePlusAge = comme;
                }
            }

            return commercialLePlusAge;
        }

        private int CalculAge(int anneeNaissance)//la methode throw new NotImplementedException() cest fais automatiquement;
        {
            throw new NotImplementedException();
        }
    }


}



