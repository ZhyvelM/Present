using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Present.Sorters
{
    class CandyBySugarSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            if (x.Sugar < y.Sugar) return 1;
            else if (x.Sugar > y.Sugar) return -1;
            else return 0;
        }
    }
}