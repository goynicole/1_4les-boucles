using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)//on déclare la variable dans la boucle, la variable est détruite à la fin
            {
                Console.WriteLine("Bonjour, je suis un message réussi à l'aide d'une boucle.");
            }
            Console.ReadKey();
        }
    }
}
