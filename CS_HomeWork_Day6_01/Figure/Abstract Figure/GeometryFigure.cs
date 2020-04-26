using System;

namespace CS_HomeWork_Day6_01.Figure
{
    public abstract class GeometryFigure
    {
        protected int FigureArea;
        protected int FigurePerimeter;

        public void WriteFigureName(string Name)
        {
            Console.Write($"Фигура: {Name}, ");
        }
    }
}
