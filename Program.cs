using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <int> purchasesPrices = new Queue <int>();
            bool isQueueEmpty = false;
            int storeBallance = 0;

            FillQueue(purchasesPrices);

            while (isQueueEmpty == false)
            {
                Console.WriteLine($"В магазин зашел покупатель и совершил покупок на {purchasesPrices.Peek()} тугриков. Осталось покупателей в очереди - {purchasesPrices.Count() -1}");
                storeBallance += purchasesPrices.Dequeue();
                Console.WriteLine($"Баланс магазина - {storeBallance} тугриков");

                if (purchasesPrices.Count == 0)
                {
                    isQueueEmpty = true;
                }

                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void FillQueue(Queue<int> purchasesPrices)
        {
            Random random = new Random();
            int numberOfBuyers = 10;
            int priceMin = 10;
            int priceMax = 1000;

            for (int i = 0; i < numberOfBuyers; i++)
            {
                purchasesPrices.Enqueue(random.Next (priceMin,priceMax+1));
            }
        }
    }
}
