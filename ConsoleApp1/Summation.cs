using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Summation
    {
        public void Two_sum_zero_solution(int[] arr, int arr_size)
        {
            int min_value = arr[0]+ arr[1];
            int new_value;
            int index1 = 0;
            int index2 = 0;

            if (arr != null || arr_size > 2)
            {
                for (int i = 0; i < arr_size; i++)
                {
                    for (int j = i+1; j < arr_size; j++)
                    {
                        new_value = arr[i] + arr[j];
                        if (Math.Abs(min_value) > Math.Abs(new_value)) 
                        {
                            index1 = i;
                            index2 = j;
                        }
                    }
                }
                Console.Write("The 2 values who's sum is closest to 0 are " + arr[index1] + " and " +arr[index2]+ "\n " +
                    "the respective indices are " +index1+ " and "+index2 );
            }
            else 
            {
                Console.Write("Invalid array");
            }
        }



        public void Two_sum_solution(int[] arr, int sum)
        {
            int arr_length = arr.Length;
            int index1;
            int index2;

            if (arr_length > 1)
            {
                for (int i = 0; i < arr_length; i++)
                {
                    for (int j=i+1; j < arr_length; j++)
                    {
                        if (sum == arr[j] + arr[i]) 
                        {
                            index1 = i;
                            index2 = j;
                            Console.Write("The indices are " + index2 + " and " + index1);
                        }
                    }
                }
            }
            else 
            {
                Console.Write("Invalid array");
            }
        }

    }


    


}
