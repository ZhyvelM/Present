using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    [Serializable]
    class CandyBar : Candy
    {
        public CandyBar(string name, string manufacturer, double weight, double sugar, int count) : base(name, manufacturer, weight, sugar, count)
        {
        }
    }
}
