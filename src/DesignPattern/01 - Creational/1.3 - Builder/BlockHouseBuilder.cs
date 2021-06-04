using System;

namespace DesignPattern.Creational.Builder
{
    public class BlockHouseBuilder : ConstructionBuilder
    {
        public BlockHouseBuilder()
        {
            house.HouseType = HouseType.Block;
        }

        public override void BuildDoor(int quantity)
        {
            house.Door = quantity;
            Console.WriteLine("Criado a porta da casa de bloco.");
        }

        public override void BuildGarage(bool check)
        {
            house.Garage = check;
            Console.WriteLine("Criado a garagem da casa de bloco");
        }

        public override void BuildPool(bool check)
        {
            house.Pool = check;
            Console.WriteLine("Criado a piscina da casa de bloco");
        }

        public override void BuildWall(int quantity)
        {
            house.Wall = quantity;
            Console.WriteLine("Criado a parede da casa de bloco");
        }

        public override void BuildWindow(int quantity)
        {
            house.Window = quantity;
            Console.WriteLine("Criado a janela da casa de bloco");
        }
    }
}
