using System;
using System.Collections.Generic;
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
    }
}
