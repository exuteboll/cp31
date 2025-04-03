using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static List<Figure> figures = new List<Figure>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Добавить фигуру");
                Console.WriteLine("2. Показать список фигур");
                Console.WriteLine("3. Показать детали фигуры");
                Console.WriteLine("4. Редактировать фигуру");
                Console.WriteLine("5. Удалить фигуру");
                Console.WriteLine("6. Вычислить площадь/периметр");
                Console.WriteLine("7. Выход");
                Console.Write("Выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Введите число от 1 до 7.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddFigure(); break;
                    case 2: ShowList(); break;
                    case 3: ShowDetails(); break;
                    case 4: EditFigure(); break;
                    case 5: DeleteFigure(); break;
                    case 6: Calculate(); break;
                    case 7:
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Введите число от 1 до 7.");
                        break;
                }
            }
        }

        static void AddFigure()
        {
            Console.WriteLine("\n1. Прямоугольник");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Круг");
            Console.Write("Выберите тип фигуры: ");

            if (!int.TryParse(Console.ReadLine(), out int type) || type < 1 || type > 4)
            {
                Console.WriteLine("Неверный выбор типа фигуры");
                return;
            }

            switch (type)
            {
                case 1:
                    figures.Add(Rectangle.Enter());
                    break;
                case 2:
                    figures.Add(Square.Enter());
                    break;
                case 3:
                    figures.Add(Triangle.Enter());
                    break;
                case 4:
                    figures.Add(Circle.Enter());
                    break;
            }
            Console.WriteLine("Фигура успешно добавлена!");
        }

        static void ShowList()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Список фигур пуст");
                return;
            }
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"{i}. {figures[i].Name} - {figures[i].GetType().Name}");
            }
        }

        static void ShowDetails()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Список фигур пуст");
                return;
            }
            ShowList();
            Console.Write("Выберите номер фигуры: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= figures.Count)
            {
                Console.WriteLine("Неверный номер фигуры");
                return;
            }
            figures[index].Print();
        }

        static void EditFigure()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Список фигур пуст");
                return;
            }
            ShowList();
            Console.Write("Выберите номер фигуры: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= figures.Count)
            {
                Console.WriteLine("Неверный номер фигуры");
                return;
            }

            switch (figures[index])
            {
                case Rectangle r:
                    Console.Write("Новая сторона 1: ");
                    r.Side1 = double.Parse(Console.ReadLine());
                    Console.Write("Новая сторона 2: ");
                    r.Side2 = double.Parse(Console.ReadLine());
                    break;
                case Square s:
                    Console.Write("Новая сторона: ");
                    s.Side1 = double.Parse(Console.ReadLine());
                    break;
                case Triangle t:
                    Console.Write("Новая сторона A: ");
                    t.Side1 = double.Parse(Console.ReadLine());
                    Console.Write("Новая сторона B: ");
                    t.Side2 = double.Parse(Console.ReadLine());
                    Console.Write("Новая сторона C: ");
                    t.Side3 = double.Parse(Console.ReadLine());
                    break;
                case Circle c:
                    Console.Write("Новый радиус: ");
                    c.Radius = double.Parse(Console.ReadLine());
                    break;
            }
            Console.WriteLine("Фигура успешно отредактирована!");
        }

        static void DeleteFigure()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Список фигур пуст");
                return;
            }
            ShowList();
            Console.Write("Выберите номер фигуры: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= figures.Count)
            {
                Console.WriteLine("Неверный номер фигуры");
                return;
            }
            figures.RemoveAt(index);
            Console.WriteLine("Фигура успешно удалена!");
        }

        static void Calculate()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("Список фигур пуст");
                return;
            }
            ShowList();
            Console.Write("Выберите номер фигуры: ");
            if (!int.TryParse(Console.ReadLine(), out int index) || index < 0 || index >= figures.Count)
            {
                Console.WriteLine("Неверный номер фигуры");
                return;
            }
            Console.WriteLine($"Площадь: {figures[index].Area():F2}");
            Console.WriteLine($"Периметр: {figures[index].Perimeter():F2}");
        }
    }
}