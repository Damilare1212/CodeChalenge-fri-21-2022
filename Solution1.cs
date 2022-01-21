using System;
using System.Collections.Generic;

namespace ChalengeCode
{
    class Solution1
    {
        public static void Answer()
        {
            int input = 10;
          //  int input = 8;
          //  int input = 5;
            int count = 0;
                int i = 1;

                while(input >= 0)
                {            

                    input = input - i;
                    count++;
                    i++;


                }
                Console.WriteLine(count-1);



        }
    }
}