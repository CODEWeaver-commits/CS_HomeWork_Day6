using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Rhombus : GeometryFigure
    {
        public int NumberOfCorners { get; private set; }
        public float Angle { get; private set; }
        public Rhombus(float Angle)
        {
            NumberOfCorners = 4;
            this.Angle = Angle;
        }

        public void ShowInfo()
        {
            WriteFigureName("Ромб");
            Console.WriteLine($"Количество углов: {NumberOfCorners}, Угол: {Angle}.");
        }
    }
}
