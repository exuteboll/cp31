using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp19
{
    internal class Rectangle : Figure
    {
        private double side1;
        private double side2;

        public double Side1 { get { return side1; } set { side1 = value; } }
        public double Side2 { get {return side2; } set { side2 = value; } }

        public Rectangle(string name, double side1, double side2) : base(name)
        {

            Side1 = side1;
            Side2 = side2;

        }

        public override double Area()
        {
            return Side1 * Side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public override void Print()
        {
            Console.WriteLine($"Название:{Name}\t Первая сторона: {Side1}\t +  Вторая сторона: {Side2}");
        }

        public static Rectangle Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите первую сторону: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double side2 = double.Parse(Console.ReadLine());
            return new Rectangle(name, side1, side2);
        }
    }
}
