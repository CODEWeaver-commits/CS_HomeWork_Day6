using System;
using static System.Console;
using CS_HomeWork_Day6_01.Figure;

namespace CS_HomeWork_Day6_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            circle.ShowInfo();
            Ellipse ellipse = new Ellipse(4, 6);
            ellipse.ShowInfo();
            ReadKey();
        }
    }
}
