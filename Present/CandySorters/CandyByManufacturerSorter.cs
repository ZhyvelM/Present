using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Present.Sorters
{
    class CandyByManufacturerSorter : IComparer<Candy>
    {
        public int Compare([AllowNull] Candy x, [AllowNull] Candy y)
        {
            return x.Manufacturer.CompareTo(y.Manufacturer);
        }
    }
}