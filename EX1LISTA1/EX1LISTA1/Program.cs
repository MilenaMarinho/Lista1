using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1LISTA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inverteTela();
            Retangulo r;
            r = new Retangulo();
            Console.Write("Informe a altura: ");
            r.setAltura(double.Parse(Console.ReadLine()));
            Console.Write("Informe a base: ");
            r.setBase(double.Parse(Console.ReadLine()));
            r.calcularArea();
            Console.WriteLine(" A área do retângulo é: {0}",
                r.getArea());
        }
        static void inverteTela()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }

    }

}
  