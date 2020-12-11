using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    [Serializable]
    class CandyBar : Candy
    {
        bool ContainsNuts { get; }
        public CandyBar(string name, string manufacturer, double weight, double sugar, int count, bool nuts) : base(name, manufacturer, weight, sugar, count)
        {
            ContainsNuts = nuts;
        }

        public override string ToString()
        {
            string str;
            if (ContainsNuts) str = "contains nuts"; else str = "without nuts";
            return base.ToString() + str;
        }
    }
}
