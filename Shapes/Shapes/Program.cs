using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Hexagon hex = new Hexagon("Beth");
            hex.Draw();

            Circle circle = new Circle("Cindy");
            circle.Draw();

            Console.ReadLine();
        }
    }
}
