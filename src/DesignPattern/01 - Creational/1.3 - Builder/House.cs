using System;

namespace DesignPattern.Creational.Builder
{
    public class House
    {
        public House()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int Wall { get; set; }
        public int Door { get; set; }
        public int Window { get; set; }
        public bool Garage { get; set; }
        public bool Pool { get; set; }
        public HouseType HouseType { get; set; }
    }
}
