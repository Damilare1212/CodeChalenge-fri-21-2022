using System;
using System.Collections.Generic;

namespace ChalengeCode
{
    class Solution2
    {
        public static void Answer()
        {
            int count = 0;
            bool check = false;
            int max = 0;
            int[] nums  = {1,3,2,2,5,2,3,7};
          //   int[] nums  = {1,2,3,4};
          //  int[] nums  = {1,1,1,1};
            for(int i = 0; i< nums.Length; i++)
            {
                count = 0;
                check = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                    else if (nums[i] == nums[j] + 1)
                    {
                        count++;
                        check = true;
                    }
                }
                if (check)
                {
                  // max = Math.Max(count,max);
                  if (count > max)
                  {
                      max = count;
                  }
                }
              //   Console.WriteLine(max);
            }
           
             Console.WriteLine(max);

             
        }
    }
}