using System;
using System.Threading;
using CS_HomeWork_Day6_02.Simple_Figure;

namespace CS_HomeWork_Day6_02.Console
{
    public static class Input
    {
        public static void InputRequest(int counter, int NumberOfNAngle, ref SimpleNAngle[] nAngle)
        {
            Output.WriteInputText(counter);
            GetInput(NumberOfNAngle, ref nAngle); 
        }
        public static void GetInput(int NumberOfNAngle, ref SimpleNAngle[] nAngle)
        {
            Random random = new Random();
            nAngle[NumberOfNAngle] = new SimpleNAngle(random.Next(100), random.Next(50), random.Next(15), random.Next(25), random.Next(100));
            Thread.Sleep(100);
        }
    }
}
