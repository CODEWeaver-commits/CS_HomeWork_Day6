using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Rectangle : GeometryFigure
    {
        public int NumberOfCorners { get; private set; }
        public int Lenght { get; private set; }
        public Rectangle(int Lenght)
        {
            NumberOfCorners = 4;
            this.Lenght = Lenght;
        }
        public void ShowInfo()
        {
            WriteFigureName("Прямоугольник");
            Console.WriteLine($"Количество углов: {NumberOfCorners}, Длина: {Lenght}.");
        }
    }
}
