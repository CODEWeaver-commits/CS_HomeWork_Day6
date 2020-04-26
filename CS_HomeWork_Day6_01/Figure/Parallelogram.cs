using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Parallelogram : GeometryFigure
    {
        public int NumberOfCorners { get; set; }
        public int Lenght { get; set; }

        public Parallelogram(int Lenght)
        {
            NumberOfCorners = 4;
            this.Lenght = Lenght;
        }
        public void ShowInfo()
        {
            WriteFigureName("Паралелограм");
            Console.WriteLine($"Количество углов: {NumberOfCorners}, Длина: {Lenght}.");
        }
    }
}
