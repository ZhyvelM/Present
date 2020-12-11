using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    [Serializable]
    class Lolipop : Candy
    {
        int AvgDurationOfLicking { get; }
        public Lolipop(string name, string manufacturer, double weight, double sugar, int count, int duration) : base(name, manufacturer, weight, sugar, count)
        {
            AvgDurationOfLicking = duration;
        }

        public override string ToString()
        {
            return base.ToString() + $" average duration of licking:{AvgDurationOfLicking}";
        }
    }
}
