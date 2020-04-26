using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public class Square : GeometryFigure
    {
        public int NumberOfCorners { get; private set; }
        public int Size { get; private set; }

        public Square(int Size)
        {
            this.Size = Size;
            NumberOfCorners = 4;
        }
        public void ShowInfo()
        {
            WriteFigureName("Квадрат");
            Console.WriteLine($"Радиус: {NumberOfCorners}, Размер: {Size}.");
        }
    }
}
