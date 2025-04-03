using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите опции");
                Console.WriteLine("1. Добавить новую фигуру");
                Console.WriteLine("2. просмотр всех фигур");
                Console.WriteLine("3.просмотр характ. фигур");
                Console.WriteLine("4. редатировать характ фигур");
                Console.WriteLine("5. удалить фигуру");
                Console.WriteLine("6. Вычислить площадь/периметр");
                Console.WriteLine("7. Выход");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("1. Square\n2. Triangle\n3. Circle");
                        string type = Console.ReadLine();
                        if (type == "1")
                        {
                            Console.Write("Enter side length: ");
                            double side = double.Parse(Console.ReadLine());
                            figures.Add(new Square(side));
                        }
                        else if (type == "2")
                        {
                            Console.Write("Enter three sides: ");
                            double side1 = double.Parse(Console.ReadLine());
                            double side2 = double.Parse(Console.ReadLine());
                            double side3 = double.Parse(Console.ReadLine());
                            figures.Add(new Triangle(side1, side2, side3));
                        }
                        else if (type == "3")
                        {
                            Console.Write("Enter radius: ");
                            double radius = double.Parse(Console.ReadLine());
                            figures.Add(new Circle(radius));
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                        break;
                }
            }
            
        }

    }
}
