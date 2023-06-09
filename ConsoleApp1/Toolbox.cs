using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Toolbox
    {
        //Version 1 of binary search
        static int myBinarySearch(List<int> elements, int x) 
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int) ((start + stop)/2);

            //Checking if the element at the middle index is X
            while (elements [middle] != x && start < stop) 
            {
                if (x < elements[middle])
                {
                    stop = middle - 1;
                }
                else 
                {
                    start = middle + 1;
                }

                middle = (int) ((start + stop)/2);  
            }

            return (elements[middle] != x) ? -1: middle;
        }



        public int NewBinarySearch(int[] the_arr, int left, int right, int target_item) 
        {
            if (left <= right) 
            {
                int middle = (left + right)/2;

                if (the_arr[middle] == target_item) 
                {
                    return target_item;
                }
            }
            return -1;
        }

    }
}
