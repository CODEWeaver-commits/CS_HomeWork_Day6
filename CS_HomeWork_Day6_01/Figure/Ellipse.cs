using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Ellipse : GeometryFigure
    {
        public float Radius { get; private set; }
        public int Lenght { get; private set; }
        public Ellipse(float Radius, int Lenght)
        {
            this.Radius = Radius;
            this.Lenght = Lenght;
        }
        public void ShowInfo()
        {
            WriteFigureName("Эллипс");
            Console.WriteLine($"Радиус: {Radius}, Длина: {Lenght}.");
        }
    }
}
