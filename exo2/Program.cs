using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)// le message s'affiche de 1 à 10
            {
                i++;//on incrémente i
                Console.WriteLine("Bonjour, je suis le message n°" + i);
             }
        }
    }
}
