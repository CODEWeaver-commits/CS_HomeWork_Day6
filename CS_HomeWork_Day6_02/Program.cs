using CS_HomeWork_Day6_02.Composition_Figure;

namespace CS_HomeWork_Day6_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionFigure composition = new CompositionFigure(5);
            composition.ShowNAngles();
            System.Console.ReadKey();
        }
    }
}
