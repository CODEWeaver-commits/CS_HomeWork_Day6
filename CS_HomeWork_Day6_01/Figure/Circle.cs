using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Circle : GeometryFigure
    {
        public float Radius { get; private set; }
        public Circle(float Radius)
        {
            this.Radius = Radius;
            FigureArea = 4;
            FigurePerimeter = 5;
        }
        public void ShowInfo()
        {
            WriteFigureName("Круг");
            Console.WriteLine($"Радиус: {Radius}, Площадь: {FigureArea}, Периметр: {FigurePerimeter}.");
        }
    }
}
