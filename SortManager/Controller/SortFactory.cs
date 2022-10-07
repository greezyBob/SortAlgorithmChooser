using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;
using Model;

namespace SortManagerControllers
{
    public class SortFactory
    {
        public ISortable ChooseSorter(int input)
        {
            switch (input)
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