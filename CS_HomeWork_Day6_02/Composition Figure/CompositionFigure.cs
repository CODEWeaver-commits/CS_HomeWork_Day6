using System;
using CS_HomeWork_Day6_02.Simple_Figure;

namespace CS_HomeWork_Day6_02.Composition_Figure
{
    public class CompositionFigure
    {
        SimpleNAngle[] nAngle;
        public CompositionFigure(int QuantityOfNAngles)
        {
            if (QuantityOfNAngles <= 0)
            {
                System.Console.Clear();
                //Console.WriteLine("Ошибка, количество угольников должно быть больше нуля.");
                throw new NullReferenceException("Ошибка, количество угольников должно быть больше нуля.");
            }
            else 
            {
                nAngle = new SimpleNAngle[QuantityOfNAngles];
                int counter = 0;
                for (int i = 0; i < QuantityOfNAngles; i++)
                {
                    Console.Input.InputRequest(++counter, i, ref nAngle);
                }
            }
        }
        public void ShowNAngles()
        {
            Console.Output.WriteOutputText(nAngle);
        }
    }
}
