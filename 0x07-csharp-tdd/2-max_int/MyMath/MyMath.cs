using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary> class for input</summary>
    public class Operations
    {
        ///<summary> method that returns the max</summary>
        public static int Max(List<int> nums)
        {
            if(nums == null || nums.Count == 0)
            {
                return 0;
            }
            int max = nums[0];
            foreach(int i in nums)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
