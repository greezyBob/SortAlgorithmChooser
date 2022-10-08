using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class MergeSortModel : ISortable
    {
        public int[] Sort(int[] arr)
        {
            //base
            if (arr.Length == 1) return arr;

            //split
            int[] leftArr = new int[arr.Length / 2];
            int[] rightArr = new int[arr.Length - leftArr.Length];

            for (int i = 0; i < leftArr.Length; i++)
                leftArr[i] = arr[i];

            for (int i = leftArr.Length, j = 0; i < arr.Length; i++, j++)
                rightArr[j] = arr[i];

            leftArr = Sort(leftArr);
            rightArr = Sort(rightArr);

            return Merge(leftArr, rightArr);
        }

        public int[] Merge(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            for (; k < result.Length; k++)
            {
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                        result[k] = arr1[i++];
                    else
                        result[k] = arr2[j++];
                }
                else if (i < arr1.Length)
                {
                    result[k] = arr1[i++];
                }
                else
                {
                    result[k] = arr2[j++];
                }
            }

            return result;
        }
    }
}