using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Triangle : GeometryFigure
    {
        public int NumberOfCorners { get; private set; }
        public float Height { get; private set; }
        public float Lenght { get; private set; }
        public Triangle(float Height, float Lenght)
        {
            NumberOfCorners = 3;
            this.Height = Height;
            this.Lenght = Lenght;
        }
        public void ShowInfo()
        {
            WriteFigureName("Треугольник");
            Console.WriteLine($"Количество углов: {NumberOfCorners}, Длина: {Lenght}, Высота {Height}.");
        }
    }
}
