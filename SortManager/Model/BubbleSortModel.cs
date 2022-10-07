using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BubbleSortModel : ISortable
    {
        public int[] Sort(int[] nums)
        {
            if (nums == null)
                throw new ArgumentNullException();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            return nums;
        }
    }
}