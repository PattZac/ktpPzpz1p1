using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktpPzpz1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite neku rečenicu: ");
            string s = Console.ReadLine();
            if (s.Length < 5) {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(s.Substring(2, s.Length - 4));
            }
            Console.ReadKey();
        }
    }
}
