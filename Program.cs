using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gyalogpatrik;
using csorelevente;

namespace foprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a szoba oldalait");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Adja meg a szoba magasságát");
            int m = int.Parse(Console.ReadLine());

            double alapterulet = gyalogpatrik.main.alapterulet(a, b);
            double palast = csorelevente.main.palast(a, b, m);

            Console.WriteLine("A szoba alapterülete: " + alapterulet);
            Console.WriteLine("Szoba oldalainak területe: " + palast);
        }
    }
}
