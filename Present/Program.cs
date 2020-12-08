using System;

namespace Present
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYearGift gift = new NewYearGift();
            gift.Add(new CandyBar("Snickers", "Nutella", 100, 10, 5));
            gift.Add(new Lolipop("Chupa Chups", "Chupa Chups", 30, 5, 1));
            gift.Add(new BubbleGum("Hubba bubba", "Wrigley", 60, 10, 2));
            gift.Add(new Marmalade("Marmalade Fruits", "no information", 50, 20, 10));


            Console.WriteLine(gift);
            gift.SortByName();
            Console.WriteLine(gift);
            gift.SortByManufacturer();
            Console.WriteLine(gift);
            gift.SortByWeigth();
            Console.WriteLine(gift);
            gift.SortBySugar();
            Console.WriteLine(gift);
            Console.WriteLine("total weigth:" + gift.GetWeight()+"\n");
            foreach(Candy c in gift.GetCandiesBySugarRange(7,12))
            {
                Console.Write(c);
            }
        }
    }
}
