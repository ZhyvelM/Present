using System;

namespace Present
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYearGift gift = new NewYearGift();
            gift.add(new CandyBar("Snickers", "Nutella", 100, 10, 5));
            gift.add(new Lolipop("Chupa Chups", "Chupa Chups", 30, 5, 1));
            gift.add(new BubbleGum("Hubba bubba", "Wrigley", 60, 10, 2));
            gift.add(new Marmalade("Marmalade Fruits", "no information", 50, 20, 10));


            Console.WriteLine(gift);
            gift.sortByName();
            Console.WriteLine(gift);
            gift.sortByManufacturer();
            Console.WriteLine(gift);
            gift.sortByWeigth();
            Console.WriteLine(gift);
            gift.sortBySugar();
            Console.WriteLine(gift);
            Console.WriteLine("total weigth:" + gift.getWeight()+"\n");
            foreach(Candy c in gift.getCandiesBySugarRange(7,12))
            {
                Console.Write(c);
            }
        }
    }
}
