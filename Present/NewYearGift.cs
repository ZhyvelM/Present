using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    class NewYearGift
    {
        List<Candy> candies;

        public NewYearGift()
        {
            candies = new List<Candy>();
        }

        public override string ToString()
        {
            string output = "";
            foreach (Candy c in candies) 
            {
                output += c;
            }
            return output;
        }

        public void add(Candy candy)
        {
            candies.Add(candy);
        }

        public double getWeight()
        {
            double totalWeight = 0;
            foreach (Candy c in candies)
            {
                totalWeight += c.weight * c.count;
            }
            return totalWeight;
        }

        public List<Candy> getCandiesBySugarRange(double x, double y)
        {
            List<Candy> newList = new List<Candy>();
            if (x > y)
            {
                double c = x;
                x = y;
                y = c;
            }
            foreach (Candy c in candies)
            {
                if (c.sugar >= x && c.sugar <= y)
                newList.Add(c);
            }
            return newList;
        }

        public void sortByWeigth()
        {
            candies.Sort(new Candy_SortByWeight());
        }

        public void sortBySugar()
        {
            candies.Sort(new Candy_SortBySugar());
        }

        public void sortByName()
        {
            candies.Sort(new Candy_SortByName());
        }

        public void sortByManufacturer()
        {
            candies.Sort(new Candy_SortByManufacturer());
        }
    }
}
