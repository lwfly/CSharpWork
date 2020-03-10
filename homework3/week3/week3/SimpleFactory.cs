using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class SimpleFactory
    {
        private static Random s = new Random();

        public static Graphical NewShape(string type)
        {
            switch (type.ToLower())
            {
                case "rectangle":
                    return new Rectangle(10 * s.NextDouble(), 10 * s.NextDouble());
                case "square":
                    return new Square(10 * s.NextDouble());
                case "triangle":
                    return new Triangle(10 * s.NextDouble(), 10 * s.NextDouble(), 10 * s.NextDouble());
                default:
                    throw new ArgumentException(message: "error");
            }
        }

        public static string GetResult()
        {
            string[] shapes = { "rectangle", "square", "triangle" };
            return shapes[s.Next(0, 3)];
        }

    }

}