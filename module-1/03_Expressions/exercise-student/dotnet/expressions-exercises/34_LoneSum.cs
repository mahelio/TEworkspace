namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another
         of the values, it does not count towards the sum.
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c) //better for bool or int??
            //idk how to do this, took me hours. sought help
        {
            bool aDuplicate = false;
            bool bDuplicate = false;
            bool cDuplicate = false;
            if (a == b)
            {
                aDuplicate = true;
                bDuplicate = true;
            }
            if (a == c)
            {
                aDuplicate = true;
                cDuplicate = true;
            }
            if (b == c)
            {
                bDuplicate = true;
                cDuplicate = true;
            }

            if (aDuplicate) a = 0;
            if (bDuplicate) b = 0;
            if (cDuplicate) c = 0;

            return a + b + c;
        
        }
            
        }
    }



