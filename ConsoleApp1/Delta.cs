using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Delta
    {
        public void Displayer()
        {
            int sum = 0;
            int counter = 0;
            int[] my_array = { 4, 2, 3, 7, 9, 1 };
            foreach (int i in my_array)
            {
                //Console.WriteLine(i + "The winner is also " + my_array[counter]);
                Console.WriteLine(sum = i + my_array[counter + 1]);
                counter++;

            }
        }

        public void Minor(int[] the_array, int the_length)
        {
            int first_index = 0;
            int second_index = 0;
            int base_sum = the_array[0] + the_array[1];



            if (the_length < 2)
            {
                Console.WriteLine("Invalid array provided");
            }
            else
            {
                for (int i = 0; i < the_length; i++)
                {
                    for (int j = i + 1; 0 < the_length; j++)
                    {
                        int new_sum = the_array[i] + the_array[j];

                        if (new_sum < base_sum)
                        {
                            base_sum = new_sum;
                            first_index = i;
                            second_index = j;
                        }
                    }
                }

                Console.WriteLine("The 2 indices are " + first_index + " and " + second_index + " the summation of their values gives " + base_sum);
            }
        }

        // This method returns the sum of 2 pairs of elements in an array that's closest to zero
        public void find_num_pair(int[] array, int length)
        {
            if (length < 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int min_sum = array[0] + array[1];
            int min_index1 = 0;
            int min_index2 = 1;
            int new_sum;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    new_sum = array[i] + array[j];

                    if (Math.Abs(new_sum) < Math.Abs(min_sum))
                    {
                        min_sum = new_sum;

                        min_index1 = i;
                        min_index2 = j;
                    }
                }
            }

            Console.Write("The two indices who's sum returns a value closest to zero are " + min_index1 + " and " + min_index2 + "\n;the sum is " + min_sum + ". The numbers are " + array[min_index1] + " and " + array[min_index2]);

        }

        //This method finds the sum of all repeated elements in two arrays
        public void find_non_overlap(int[] arr1, int[] arr2)
        {
            if (arr1 != null || arr2 != null)
            {
                int sum = 0;
                int sum2 = 0;

                foreach (int i in arr1)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (i == arr2[j])
                        {
                            sum2 = i;
                            sum = sum + arr2[j];
                        }
                    }
                }
                Console.Write(sum + sum2);



            }
        }



        //This method buys and sells stock to maximise profit
        public void StockBroker(int[] my_array)
        {
            int maxprofit = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < my_array.Length; i++)
            {
                if (my_array[i] < minPrice) 
                {
                    minPrice = my_array[i]; 
                }
                int profit = my_array[i] - minPrice;

                if (profit > maxprofit)
                {
                    maxprofit = profit;
                }
            }
            Console.Write(maxprofit);
        }

        //Method that buys stock at low and sells at high given an array of prices and returns the max profit 
        public void StockBroker_v2(int[] my_array)
        {
            int maxprofit = 0;
            int minPrice = int.MaxValue;
            int counter = 0;

            foreach (var i in my_array)
            {
                if (i < minPrice)
                {
                    minPrice = i;
                }
                int profit = i - minPrice;

                if (profit > maxprofit)
                {
                    maxprofit = profit;
                }
                counter++;
            }
            
            Console.Write(maxprofit);
        }

        //This method buys and sells stocks every single day when profitable and updates the maximum profit cumulatively

        //Function to return the maximum profit that can be made after buying and selling the given stocks
        static void maxProfit(int[] price,int start, int end) 
        {
            //If the stocks can't be bought
            if (end <= start) 
            {
                //return 0;
                Console.Write("Stock can't be purchased");
            }

            //Initialize the profit
            int profit = 0;


            //The day at which the stock 
            for (int i = start; i < end; i++)
            {
                for (int j = i+1; j <= end; j++)
                {
                    //If buying the stock on the ith day and selling it on the jth day is profitable
                    if (price[j] > price[i]) 
                    {
                        //Update the current profit
                        int curr_profit = price[j] - price[i] + maxProfit(price, start, i - 1) + maxProfit(price, j + 1, end);

                        // Update the maximum profit so far
                        profit = Math.Max(profit, curr_profit);

                    }

                }
            }
            Console.Write(maxProfit(price, 0, n - 1));

        }



    }
}
