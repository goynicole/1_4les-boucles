using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
              for(int i = 0; i< week.Length; i++)//signe inférieur car sa démarre à 0 || week.Length quand on connait pas la taille du tableau
            {
                Console.WriteLine(week[i]);
            }
        }
    }
}
