﻿using System;
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

            //Hexagon hex = new Hexagon("Beth");
            //hex.Draw();
            //Circle circle = new Circle("Cindy");
            //circle.Draw();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Circle("Linda") };
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            Console.ReadLine();
        }
    }
}
