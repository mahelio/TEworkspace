﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            if (words.Length != 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    int counter = 1;
                    if (!result.ContainsKey(words[i]))
                    {
                        for (int j = i + 1; j < words.Length; j++)
                        {
                            if (words[i].Equals(words[j]))
                            {
                                counter++;
                            }
                        }
                        result.Add(words[i], counter);
                    }
                }
            }
            return result;
        }
    }
}
