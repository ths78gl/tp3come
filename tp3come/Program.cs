using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_commercial
{


    namespace tp_commercial
    {


        internal class Program
        {
            static void Main(string[] args)
            {

                Categorie cat1 = new Categorie("comp", "comptabilite");
                Categorie cat2 = new Categorie("vend", "vendeur");


                Commercial commercial1 = new Commercial("kan", "tot", 2005, cat2);
                Commercial commercial2 = new Commercial("dia", "mouss", 2005, cat2);
                Commercial commercial3 = new Commercial("kalm", "exoo", 2005, cat2);
                Commercial commercial4 = new Commercial("aourak", "yaz", 2005, cat1);
                Commercial commercial5 = new Commercial("boulec", "tom", 2005, cat1);
                Commercial commercial6 = new Commercial("fou", "mathis", 2005, cat1);



                Console.WriteLine(commercial1);
                Console.WriteLine(commercial2);
                Console.WriteLine(commercial3);
                Console.WriteLine(commercial4);
                Console.WriteLine(commercial5);
                Console.WriteLine(commercial6);




                Service serviceNational = new Service("National");
                Service serviceInternational = new Service("International");


                // Ajout des commerciaux aux services
                serviceNational.AjouterCom(commercial1);
                serviceNational.AjouterCom(commercial2);
                serviceNational.AjouterCom(commercial3);

                serviceInternational.AjouterCom(commercial4);
                serviceInternational.AjouterCom(commercial5);
                serviceInternational.AjouterCom(commercial6);


                Console.WriteLine(serviceNational);
                Console.WriteLine(serviceInternational);




                Console.ReadLine();
            }

        }
    }

}

