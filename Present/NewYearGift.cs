using Present.Sorters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    class NewYearGift
    {
        List<Candy> Candies { get; }

        public NewYearGift()
        {
            Candies = new List<Candy>();
        }

        public override string ToString()
        {
            string output = "";
            foreach (Candy c in Candies) 
            {
                output += c;
            }
            return output;
        }

        public void Add(Candy candy)
        {
            Candies.Add(candy);
        }

        public double GetWeight()
        {
            double totalWeight = 0;
            foreach (Candy c in Candies)
            {
                totalWeight += c.Weight * c.Count;
            }
            return totalWeight;
        }

        public List<Candy> GetCandiesBySugarRange(double min, double max)
        {
            List<Candy> newList = new List<Candy>();
            foreach (Candy c in Candies)
            {
                if (c.Sugar >= min && c.Sugar <= max)
                newList.Add(c);
            }
            return newList;
        }

        public void SortByWeigth()
        {
            Candies.Sort(new CandyByWeightSorter());
        }
        public void SortBySugar()
        {
            Candies.Sort(new CandyBySugarSorter());
        }
        public void SortByName()
        {
            Candies.Sort(new CandyByNameSorter());
        }
        public void SortByManufacturer()
        {
            Candies.Sort(new CandyByManufacturerSorter());
        }
    }
}
