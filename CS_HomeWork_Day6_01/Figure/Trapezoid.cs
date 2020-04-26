using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Trapezoid : GeometryFigure
    {
        public int NumberOfCorners { get; private set; }
        public float Height { get; private set; }
        public float Lenght { get; private set; }
        public Trapezoid(float Height, float Lenght)
        {
            NumberOfCorners = 4;
            this.Height = Height;
            this.Lenght = Lenght;
        }
        public void ShowInfo()
        {
            WriteFigureName("Трапеция");
            Console.WriteLine($"Количество углов: {NumberOfCorners}, Длина: {Lenght}, Высота {Height}.");
        }
    }
}
