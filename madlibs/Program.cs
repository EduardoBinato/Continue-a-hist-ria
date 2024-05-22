using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madlibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Escolha uma cor: ");
            color = Console.ReadLine();

            Console.Write("Escolha um adjetivo: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Escolha uma celebridade: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Rosas são " + color);
            Console.WriteLine(pluralNoun + " é azul");
            Console.WriteLine("Eu te amo " + celebrity);

            Console.ReadLine();
        }
    }
}
