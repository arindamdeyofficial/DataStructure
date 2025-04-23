using System;
using System.Collections.Generic;
using System.Linq;

namespace Binarysearch
{
    public class SortedArraysearch
    {
        public int SearchRecursion(int[] arr, int element)
        {
            int arrSize = arr.Length;
            int middleIndex = arr.Length / 2;
            if(arrSize <= 3)
            {
                return middleIndex;
            }
            if (element > arr[middleIndex]) return SearchRecursion(SubArray(arr, middleIndex + 1, arrSize), element);
            else return SearchRecursion(SubArray(arr, 0, middleIndex + 1), element);
        }
        public int[] SubArray(int[] data, int startIndex, int lastIndex)
        {
            int length = lastIndex - startIndex;
            int[] result = new int[length];
            for(var i=0;i<length; i++)
            {
                result[i] = data[startIndex + i];
            }
            return result;
        }
    }
}
