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
            Queue <int> listOfPurchase = new Queue <int>();
            int[] prices = { 456, 775, 345, 43, 808, 335, 18, 115, 452 };
            bool isQueueEmpty = false;
            int storeBallance = 0;

            FillQueue(listOfPurchase , prices);

            while (isQueueEmpty == false)
            {
                Console.WriteLine($"В магазин зашел покупатель и совершил покупок на {listOfPurchase .Peek()} тугриков. Осталось покупателей в очереди - {listOfPurchase .Count() -1}");
                storeBallance += listOfPurchase .Dequeue();
                Console.WriteLine($"Баланс магазина - {storeBallance} тугриков");

                if (listOfPurchase .Count == 0)
                {
                    isQueueEmpty = true;
                }

                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void FillQueue(Queue<int> listOfPurchase, int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                listOfPurchase.Enqueue(prices[i]);
            }
        }
    }
}
