using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Circle : Figure
    {
       private double radius;

        public double Radius { get { return radius; } set { radius = value; } }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Print()
        {
            Console.WriteLine($"Радиус: {Radius}");
        }

        public static Circle Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());
            return new Circle(name, radius);
        }
    }
}
