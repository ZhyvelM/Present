using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

namespace Present.Sorters
{
    class CandyByWeightSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            if (x.Weight < y.Weight) return 1;
            else if (x.Weight > y.Weight) return -1;
            else return 0;
        }
    }

    class CandyBySugarSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            if (x.Sugar < y.Sugar) return 1;
            else if (x.Sugar > y.Sugar) return -1;
            else return 0;
        }
    }

    class CandyByNameSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class CandyByManufacturerSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            return x.Manufacturer.CompareTo(y.Manufacturer);
        }
    }
}