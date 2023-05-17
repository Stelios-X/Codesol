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
            int[] my_array = { 4, 2, 3, 7, 9, 1};
            foreach (int i in my_array)
            {
                //Console.WriteLine(i + "The winner is also " + my_array[counter]);
                Console.WriteLine(sum = i + my_array[counter+1]);
                counter++;
                
            }
        }

        public void Minor(int[] the_array, int the_length) 
        {
            int first_index = 0;
            int second_index = 0;
            int base_sum = the_array[0]+ the_array[1];



            if (the_length < 2)
            {
                Console.WriteLine("Unfortunately, this won't work B");
            }
            else 
            {
                for (int i = 0; i < the_length; i++)
                {
                    for (int j = i+1; 0 < the_length; j++)
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

                Console.WriteLine("The 2 indices are " + first_index + " and "+second_index+ " the summation of their values gives "+base_sum);
            }    
        }

        public void find_num_pair(int[] array, int length) 
        {
            if (length <2 ) 
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
                for (int j = i+1; j < length; j++)
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

            Console.Write("The two indices who's sum returns a value closest to zero are "+min_index1+" and "+min_index2+ "\n;the sum is "+min_sum+". The numbers are " + array[min_index1]+" and " + array[min_index2]);

        }

        

    }
}
