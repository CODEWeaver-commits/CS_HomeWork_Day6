
namespace CS_HomeWork_Day6_02.Console
{
    public static class Output
    {
        public static void WriteInputText(int NumberOfNAngle)
        {
            System.Console.WriteLine($"Укажите следующие базовые параметры для НУгольника[{NumberOfNAngle}]:");
        }
        public static void WriteOutputText(Simple_Figure.SimpleNAngle[] nAngles)
        {
            int counter = 0;
            System.Console.WriteLine();
            foreach (var item in nAngles)
            {
                System.Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;
                System.Console.WriteLine($"┏══════════════════════════════════════════════┓\n" +
                                         $"┃╭────────╮\n" +
                                         $"┃│НУгол[{++counter}]│\n" +
                                         $"┃╰────────╯\n" +
                                         $"┃Высота: {item.Height}\n" +
                                         $"┃Основание: {item.Base}\n" +
                                         $"┃Угол между основанием и смежной стороной: {item.AngleBetweenBaseAndAdjacentSide}\n" +
                                         $"┃Количество стророн: {item.SidesQuantity}\n" +
                                         $"┃Длины сторон: {item.SidesLenght}\n" +
                                         $"┃Площадь: {item.Area}\n" +
                                         $"┃Периметр: {item.Perimeter}\n" +
                                         $"┗══════════════════════════════════════════════┛\n");
            }
        }
    }
}
