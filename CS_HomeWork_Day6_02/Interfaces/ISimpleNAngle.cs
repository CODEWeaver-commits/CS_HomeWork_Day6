
namespace CS_HomeWork_Day6_02.Simple_Figure
{
    interface ISimpleNAngle
    {
        int Height { get; set; }
        int Base { get; set; }
        float AngleBetweenBaseAndAdjacentSide { get; set; }
        int SidesQuantity { get; set; }
        int SidesLenght { get; set; }
        int Area { get; set; }
        int Perimeter { get; set; }

        void GetArea();
    }
}
