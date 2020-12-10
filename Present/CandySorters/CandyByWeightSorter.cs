using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

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
}