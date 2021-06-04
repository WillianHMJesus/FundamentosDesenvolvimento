namespace DesignPattern.Creational.Builder
{
    public abstract class ConstructionBuilder
    {
        protected House house;

        public House House
        {
            get { return house; }
        }

        public abstract void BuildWall(int quantity);
        public abstract void BuildDoor(int quantity);
        public abstract void BuildWindow(int quantity);
        public abstract void BuildGarage(bool check);
        public abstract void BuildPool(bool check);
    }
}
