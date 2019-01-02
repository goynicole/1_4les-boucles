using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] months = new string[] //déclare d'un nouveau tableau de chaine de caractère
            {
                "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre"
            };
            foreach (String month in months)
            {
                Console.WriteLine(month);
             }
            Console.ReadKey();
        }
    }
}
