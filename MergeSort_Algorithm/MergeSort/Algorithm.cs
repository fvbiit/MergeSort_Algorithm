//Fabian Tschuggmall
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort_Algorithm.MergeSort
{
    public class Algorithm
    {

        /*
         The DivideMergeSort method is the main method of the algorithm. 
         The recursive function call theoretically breaks down the array into its smallest components but in reality, only the indices of the array are subdivided further and further. 
         The merge method is also called in the main method and merges the array and sorts it using the indices.
         */
        public void DivideMergeSort(int[] unsorted_values, int left_index, int right_index)
        {
            if (right_index > left_index)
            {
                int middle_index = (left_index + right_index) / 2;

                //Recursive Function Call for Left index site
                DivideMergeSort(unsorted_values, left_index, middle_index);

                //Recursive Function Call for Right index site
                DivideMergeSort(unsorted_values, middle_index+1, right_index);

                //Merge Method
                Merge(unsorted_values, left_index, middle_index, right_index);

            }

        }

        /*
        The merge method takes over the unsorted array and the required indexes to merge and sort the array. 
         */
        public void Merge(int[] unsorted_values, int left_index, int middle_index, int right_index)
        {
            int left_array_length = middle_index - left_index + 1;
            int right_array_length = right_index - middle_index;
            int left_cnt, right_cnt, comparevalue_left;

            int[] left_array = new int[left_array_length];
            int[] right_array = new int[right_array_length];

            //Copies the left and right sides of the array into two temporary arrays 
            for (left_cnt = 0; left_cnt < left_array_length; ++left_cnt)
                left_array[left_cnt] = unsorted_values[left_index + left_cnt];
            for (right_cnt = 0; right_cnt < right_array_length; ++right_cnt)
                right_array[right_cnt] = unsorted_values[middle_index + 1 + right_cnt];

            left_cnt = 0;
            right_cnt = 0;
            comparevalue_left = left_index;

            while (left_cnt < left_array_length && right_cnt < right_array_length) 
            { 
                if (left_array[left_cnt] <= right_array[right_cnt])
                {
                    unsorted_values[comparevalue_left++] = left_array[left_cnt++];
                }
                else
                {
                    unsorted_values[comparevalue_left++] = right_array[right_cnt++];
                }
            }

            while (left_cnt < left_array_length)
            {
                unsorted_values[comparevalue_left++] = left_array[left_cnt++];
            }

            while (right_cnt < right_array_length)
            {
                unsorted_values[comparevalue_left++] = right_array[right_cnt++]; 
            }
        }

        /*
         This is the main function that executes the programm and display the output.
         */
        public static void Main(string[] args)
        {   
            var alg = new Algorithm();  
            int[] unsorted_values = { 10, 5, 30, 15, 7 };
            Console.WriteLine("Your given array is");
            Console.WriteLine(string.Join(" ", unsorted_values));

            alg.DivideMergeSort(unsorted_values, 0, unsorted_values.Length - 1);

            Console.WriteLine("\nYour Sorted array is");
            Console.WriteLine(string.Join(" ", unsorted_values));
        }
    }
}
