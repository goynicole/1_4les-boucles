using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int compteur = 10; compteur > 0; compteur--) //on déclare la variable dans la boucle, la variable est détruite à la fin
            {//on décrémente le compteur
                Console.WriteLine(compteur);
            }
            Console.ReadKey();
        }
    }
}
