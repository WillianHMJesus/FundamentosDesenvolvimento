using System;

namespace DesignPattern.Creational.Builder
{
    public class WoodHouseBuilder : ConstructionBuilder
    {
        public WoodHouseBuilder()
        {
            house.HouseType = HouseType.Wood;
        }

        public override void BuildDoor(int quantity)
        {
            house.Door = quantity;
            Console.WriteLine("Criado a porta da casa de madeira.");
        }

        public override void BuildGarage(bool check)
        {
            house.Garage = check;
            Console.WriteLine("Criado a garagem da casa de madeira");
        }

        public override void BuildPool(bool check)
        {
            house.Pool = check;
            Console.WriteLine("Criado a piscina da casa de madeira");
        }

        public override void BuildWall(int quantity)
        {
            house.Wall = quantity;
            Console.WriteLine("Criado a parede da casa de madeira");
        }

        public override void BuildWindow(int quantity)
        {
            house.Window = quantity;
            Console.WriteLine("Criado a janela da casa de madeira");
        }
    }
}
