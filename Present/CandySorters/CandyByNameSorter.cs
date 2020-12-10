using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Present.Sorters
{
    class CandyByNameSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}