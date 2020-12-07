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

        public double getWeight()
        {
            double totalWeight = 0;
            foreach (Candy c in candies)
            {
                totalWeight += c.weight;
            }
            return totalWeight;
        }
    }
}
