using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MergeSort_Algorithm.MergeSort;


namespace MergeSort_Algorithm.Tests.MergeSortTests
{
    public class AlgorithmTests
    {
        [Fact]
        public void Algorithm_Divide_Merge_Sort_SortedList()
        {
            var alg = new Algorithm();
            int[] input = { 10, 5, 30, 15, 7 };
            int[] expected = { 5, 7, 10, 15, 30};

            alg.Divide_Merge_Sort(input, 0, input.Length - 1);


            Assert.Equal(expected, input);
            



            

        }



    }
}
