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
        public void DivideMergeSort_UnsortedList_ReturnsSortedList()
        {
            var alg = new Algorithm();
            int[] input = { 10, 5, 30, 15, 7 };
            int[] expected = { 5, 7, 10, 15, 30};

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void DivideMergeSort_OneValueList_ReturnsOneValueList()
        {
            var alg = new Algorithm();
            int[] input = {7};
            int[] expected = {7};

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        [Fact]
        public void DivideMergeSort_EmptyList_ReturnsEmptyList()
        {
            var alg = new Algorithm();
            int[] input =  { };
            int[] expected =  { };

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }




    }
}
