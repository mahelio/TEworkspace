namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given an "outword" string length 4, such as "<<>>", and a word, return a new string where the word is in the
        middle of the outword string, e.g. "<<word>>". Note: use str.Substring(i, j) to extract the string starting
        at index i and going up to but not including index j.
        MakeOutWord("<<>>", "Yay") → "<<Yay>>"
        MakeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
        MakeOutWord("[[]]", "word") → "[[word]]"
        */
        public string MakeOutWord(string outword, string word) //starting at i, and up to but no including j
        {

            return outword.Substring(0, 2) + word + outword.Substring(2,2);
        }
    }
}
