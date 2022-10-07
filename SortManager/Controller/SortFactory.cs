using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Controller
{
    public class SortFactory
    {
        public static int[] ChooseSorter(int input, int[] arr)
        {
            int[] result = new int[arr.Length];
            if (input == 1)
            {
               var sorter = new BubbleSortModel();
               result = sorter.Sort(arr);
            }
            else if (input == 2)
            {
                var sorter = new MergeSortModel();
                result =  sorter.Sort(arr);
            }
            else if (input == 3)
            {
                var sorter = new DotNetSort();
                result = sorter.Sort(arr);
            }
            else if (input == 4)
            {
                //exit
            }
            else
            {
              //input invalid      
            }
            return result;
        }
    }
}