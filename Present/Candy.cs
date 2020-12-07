using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Present
{
    public abstract class Candy
    {
        public string name;
        public string manufacturer;
        public double weight;
        public double sugar;
        public int count;

        public Candy(string name, string manufacturer, double weight, double sugar, int count)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.weight = weight;
            this.sugar = sugar;
            this.count = count;
        }

        public override string ToString()
        {
            return name + " " + manufacturer + " weight: " + weight + " sugar: " + sugar + "\n"; ;
        }
    }
        class Candy_SortByWeight : IComparer<Candy>
        {
            public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
            {
                if (x.weight < y.weight) return 1;
                else if (x.weight > y.weight) return -1;
                else return 0;
            }
        }

        class Candy_SortBySugar : IComparer<Candy>
        {
            public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
            {
                if (x.sugar < y.sugar) return 1;
                else if (x.sugar > y.sugar) return -1;
                else return 0;
            }
        }

        class Candy_SortByName : IComparer<Candy>
        {
            public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
            {
                return x.name.CompareTo(y.name);
            }
        }

        class Candy_SortByManufacturer : IComparer<Candy>
        {
            public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
            {
                return x.manufacturer.CompareTo(y.manufacturer);
            }
        }
}
