using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode
{
    internal class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var minPriceDay = 0;
            var maxPriceDay = 0;
            var counter = 0;
            while (counter < prices.Length)
            {               
                maxPriceDay = counter;
                if (prices[counter] < prices[minPriceDay])
                {
                    minPriceDay = counter;
                }

                while (prices.Length - 1 > maxPriceDay && prices[maxPriceDay + 1] > prices[maxPriceDay])
                {
                    maxPriceDay++;
                }

                profit = Math.Max(profit, prices[maxPriceDay] - prices[minPriceDay]);
                counter = maxPriceDay + 1;
            }

            return profit;
        }
    }
}
