using System;
using System.Text;

namespace Present
{
    public abstract class Candy
    {
        public string Name { get; }
        public string Manufacturer{get; }
        public double Weight { get; }
        public double Sugar { get; }
        public int Count { get; }

        public Candy(string name, string manufacturer, double weight, double sugar, int count)
        {
            Name = name;
            Manufacturer = manufacturer;
            Weight = weight;
            Sugar = sugar;
            Count = count;
        }

        public override string ToString()
        {
            return $"{Name} Manufacturer:{Manufacturer} weight: {Weight} sugar: {Sugar}";
        }
    }
}