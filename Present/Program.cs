using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Present
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYearGift gift = new NewYearGift();
            //gift.Add(new CandyBar("Snickers", "Nutella", 100, 10, 5));
            //gift.Add(new Lolipop("Chupa Chups", "Chupa Chups", 30, 5, 1));
            //gift.Add(new BubbleGum("Hubba bubba", "Wrigley", 60, 10, 2));
            //gift.Add(new Marmalade("Marmalade Fruits", "no information", 50, 20, 10));
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("gift.dat", FileMode.OpenOrCreate))
            {
                gift = (NewYearGift)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
            }
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.Write("1. Добавить конфету\n" +
                                  "2. Отсортировать по названию\n" +
                                  "3. Отсортировать по производителю\n" +
                                  "4. Отсортировать по весу\n" +
                                  "5. Отсортировать по сахару\n" +
                                  "6. Общий вес подарка\n" +
                                  "7. Найти конфеты по содержанию сахара\n" +
                                  "для выхода любой символ\n" +
                                  "->");
                string str = Console.ReadLine();
                char c;
                if (str.Length > 1) c = '*';
                else c = str[0];
                switch (c)
                {
                    case ('1'):
                        {
                            gift.Add(new CandyBar("Nuts", "Nutella", 100, 10, 1));
                            Console.WriteLine(gift);
                        }
                        break;
                    case ('2'):
                        {
                            gift.SortByName();
                            Console.WriteLine(gift);
                        }
                        break;
                    case ('3'):
                        {
                            gift.SortByManufacturer();
                            Console.WriteLine(gift);
                        }
                        break;
                    case ('4'):
                        {
                            gift.SortByWeigth();
                            Console.WriteLine(gift);
                        }
                        break;
                    case ('5'):
                        {
                            gift.SortBySugar();
                            Console.WriteLine(gift);
                        }
                        break;
                    case ('6'):
                        {
                            Console.WriteLine("total weigth:" + gift.GetWeight() + "\n");
                        }
                        break;
                    case ('7'):
                        {
                            Console.Write("Введите минимальное число:");
                            int min = int.Parse(Console.ReadLine());
                            Console.Write("Введите максимальное число:");
                            int max = int.Parse(Console.ReadLine());

                            foreach (Candy candy in gift.GetCandiesBySugarRange(min, max))
                            {
                                Console.Write(candy);
                            }
                        }
                        break;
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
                if(flag)
                Console.ReadLine();
            }

            using (FileStream fs = new FileStream("gift.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, gift);

                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
