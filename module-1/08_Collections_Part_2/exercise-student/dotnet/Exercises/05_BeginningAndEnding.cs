﻿using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> firstWithLast = new Dictionary<string, string>();
            foreach (string word in words)
            {
                string firstLetter = "";
                string lastLetter = "";

                firstLetter = word.Substring(0, 1); //key of its first character
                lastLetter = word.Substring(word.Length - 1, 1); //value of last character

                firstWithLast[firstLetter] = lastLetter;
            }
            return firstWithLast;
        }
    }
}