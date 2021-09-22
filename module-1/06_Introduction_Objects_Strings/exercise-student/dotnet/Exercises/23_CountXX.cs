namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Count the number of "xx" in the given string. Overlapping is allowed, so "xxx" contains 2 "xx".
        CountXX("abcxx") → 1
        CountXX("xxx") → 2
        CountXX("xxxx") → 3
        */
        public int CountXX(string str)
        {
            int counter = 0;
            for (int i = str.IndexOf("xx"); i != -1; i = str.IndexOf("xx", i))
            {
                if (str.IndexOf("xx") != -1)
                {
                    counter++;
                }
                i++;
            }
            return counter;
        }
    }
}
