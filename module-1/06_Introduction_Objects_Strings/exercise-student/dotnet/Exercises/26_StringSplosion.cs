namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a non-empty string like "Code" return a string like "CCoCodCode".
        StringSplosion("Code") → "CCoCodCode"
        StringSplosion("abc") → "aababc"
        StringSplosion("ab") → "aab"
        */
        public string StringSplosion(string str)
        {
            string resultSplod = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int x = 0; x <= i; x++) //new var
                {
                    resultSplod += str[x];
                }
            }
            return resultSplod;
        }
    }
}
