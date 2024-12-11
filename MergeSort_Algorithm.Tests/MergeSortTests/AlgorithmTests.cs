using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MergeSort_Algorithm.MergeSort;

/*This code section tests the functionality of the merge-sort algorithm using individual tests with Xunit.*/
namespace MergeSort_Algorithm.Tests.MergeSortTests
{
    public class AlgorithmTests
    {

        //Tests the merge-sort algorithm using a normal unsorted array.
        [Fact]
        public void DivideMergeSort_UnsortedList_ReturnsSortedArray()
        {
            var alg = new Algorithm();
            int[] input = { 10, 5, 30, 15, 7 };
            int[] expected = { 5, 7, 10, 15, 30};

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        //Tests the merge-sort algorithm using an array with a value.
        [Fact]
        public void DivideMergeSort_OneValueList_ReturnsOneValueArray()
        {
            var alg = new Algorithm();
            int[] input = {7};
            int[] expected = {7};

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        //Tests the merge-sort algorithm using an empty array.
        [Fact]
        public void DivideMergeSort_EmptyList_ReturnsEmptyArray()
        {
            var alg = new Algorithm();
            int[] input =  { };
            int[] expected =  { };

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        //Tests the merge-sort algorithm using a sorted array.
        [Fact]
        public void DivideMergeSort_EmptyList_ReturnsAlreadySortedArray()
        {
            var alg = new Algorithm();
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        //Tests the merge-sort algorithm using an unsorted array with duplicates.
        [Fact]
        public void DivideMergeSort_EmptyList_ReturnsSortedArrayWithDuplicates()
        {
            var alg = new Algorithm();
            int[] input = { 5, 1, 5, 12, 2, 4 };
            int[] expected = { 1, 2, 4, 5, 5, 12 };

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

        //Tests the merge-sort algorithm using an unsorted array with positive and negative values.
        [Fact]
        public void DivideMergeSort_EmptyList_ReturnsSortedArrayWithNegativeNumbers()
        {
            var alg = new Algorithm();
            int[] input = { -1, -3, 5, 1, 8 };
            int[] expected = { -3, -1, 1, 5, 8 };

            alg.DivideMergeSort(input, 0, input.Length - 1);

            Assert.Equal(expected, input);
        }

    }
}
