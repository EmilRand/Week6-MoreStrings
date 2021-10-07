using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string perekonnanimi = Console.ReadLine();

            string nimi = $"{eesnimi}{perekonnanimi}".ToLower();
            int counter = 0;
            foreach (char c in nimi)
            {
             if (c == 'a')
             {
               counter++;
             }



            }
            int a = counter;
            Console.WriteLine(a);


        }
    }
}
