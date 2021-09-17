﻿namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        9. We want this loop to only count every other item starting at zero.
        What needs to change in the loop for it to do that?
        TOPIC: Looping Through Arrays

            // { 4, 3, 4, 1, 4, 6 }; -> 12

        */
        public int ReturnSumEveryOtherNumber(int[] arrayToLoopThrough)
        {
            int sum = 0;

            //     Start;       Keep going while         Increment by two;
            for (int i = 0; i <arrayToLoopThrough.Length; i = i+2)
            {
                sum = sum + arrayToLoopThrough[i];
            }

            return sum;
        
         }
    }
}
