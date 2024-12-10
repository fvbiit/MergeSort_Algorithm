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

        public void DivideMergeSort(int[] unsorted_values, int left_index, int right_index)
        {
            if (right_index > left_index)
            {
                int middle_index = (left_index + right_index) / 2;

                //Recursive Function Call for Left
                DivideMergeSort(unsorted_values, left_index, middle_index);

                //Recursive Function Call for Right
                DivideMergeSort(unsorted_values, middle_index+1, right_index);

                Merge(unsorted_values, left_index, middle_index, right_index);

            }

        }

        public void Merge(int[] unsorted_values, int left_index, int middle_index, int right_index)
        {
            int left_array_length = middle_index - left_index + 1;
            int right_array_length = right_index - middle_index;
            int a, b, c;

            int[] left_array = new int[left_array_length];
            int[] right_array = new int[right_array_length];

            for (a = 0; a < left_array_length; ++a)
                left_array[a] = unsorted_values[left_index + a];
            for (b = 0; b < right_array_length; ++b)
                right_array[b] = unsorted_values[middle_index + 1 + b];

            a = 0;
            b = 0;
            c = left_index;

            while (a < left_array_length && b < right_array_length) 
            { 
                if (left_array[a] <= right_array[b])
                {
                    unsorted_values[c++] = left_array[a++];
                }
                else
                {
                    unsorted_values[c++] = right_array[b++];
                }
            }

            while (a < left_array_length)
            {
                unsorted_values[c++] = left_array[a++];
            }

            while (b < right_array_length)
            {
                unsorted_values[c++] = right_array[b++]; 
            }
        }

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
