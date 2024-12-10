using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gyalogpatrik;


namespace foprog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a szoba oldalait");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double alapterulet = gyalogpatrik.main.alapterulet(a, b);

            Console.WriteLine("A szoba alapterülete: " + alapterulet);
        }
    }
}
