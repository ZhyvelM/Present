using System;
using System.Collections.Generic;
using System.Text;

namespace Present
{
    [Serializable]
    class BubbleGum : Candy
    {
        int AvgDurationOfChewing { get; }
        public BubbleGum(string name, string manufacturer, double weight, double sugar, int count, int duration) : base(name, manufacturer, weight, sugar, count)
        {
            AvgDurationOfChewing = duration;
        }

        public override string ToString()
        {
            return base.ToString() + $" average duration of chewing: {AvgDurationOfChewing}";
        }
    }
}
