using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Begrüßung("Peter");
            Begrüßung("Janek");
            Console.ReadKey();
        }

        static void Begrüßung(string name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}
