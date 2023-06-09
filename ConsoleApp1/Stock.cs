using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Buying and selling stocks to maximize profit
    public class Stock
    {
        public int MaxProfit(int[] prices) 
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice) 
                {
                    minPrice = prices[i];
                }

                int profit = prices[i] - minPrice;
                if (profit > maxProfit) 
                {
                    maxProfit = profit;
                }
            }

            Console.Write(maxProfit.ToString());
            return maxProfit;
        }
    }
}
