using System;

namespace RectangleApp
{
    public class Rectangle
    {
        public double Height;
        public double Width;

        public void DisplayInfo()
        {
            Console.WriteLine($"Прямоугольник: Высота = {Height}, Ширина = {Width}");
        }

        public double Perimetr()
        {
            return (2 * Height) + (2 * Width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.Height = 2;
            rect.Width = 3;

            rect.DisplayInfo();

            double perimeter = rect.Perimetr();
            Console.WriteLine($"Периметр прямоугольника = {perimeter}");

            Console.WriteLine("Работу выполнил Никульшин Платон 26ИС");

            Console.ReadKey();
        }
    }
}

