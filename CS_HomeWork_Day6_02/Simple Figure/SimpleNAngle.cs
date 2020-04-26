
namespace CS_HomeWork_Day6_02.Simple_Figure
{
    public class SimpleNAngle : ISimpleNAngle
    {
        public int Height { get; set; }
        public int Base { get; set; }
        public float AngleBetweenBaseAndAdjacentSide { get; set; }
        public int SidesQuantity { get; set; }
        public int SidesLenght { get; set; }
        public int Area { get; set; }
        public int Perimeter { get; set; }

        public SimpleNAngle(int Height, int Base, float AngleBetweenBaseAndAdjacentSide, int SidesQuantity, int SidesLenght)
        {
            this.Height = Height;
            this.Base = Base;
            this.AngleBetweenBaseAndAdjacentSide = AngleBetweenBaseAndAdjacentSide;
            this.SidesQuantity = SidesQuantity;
            this.SidesLenght = SidesLenght;
        }
        public SimpleNAngle()
        {
            ///////////
        }

        public void GetArea()
        {
            ///////////
        }
    }
}
