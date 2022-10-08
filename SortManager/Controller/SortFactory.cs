﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Sources;
using Model;

namespace SortManagerController
{
    public static class SortFactory
    {
        public static ISortable ChooseSorter(int input)
        {
            switch (input)
            {
                case 1: return new BubbleSortModel();
                case 2: return new MergeSortModel();
                case 3: return new DotNetSort();
                default: throw new ArgumentException();

            }
        }
    }
}