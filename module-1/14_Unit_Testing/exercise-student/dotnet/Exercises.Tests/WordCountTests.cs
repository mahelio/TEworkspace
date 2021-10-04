using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    //GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
    //GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
    //GetCount([]) → { }
    //GetCount(["c", "b", "a"]) → { "c": 1, "b": 1, "a": 1}
    [TestClass]
public class WordCountTests //got help from stack
    {
        string[] array1 = { "ba", "ba", "black", "sheep" };
        Dictionary<string, int> expected1 = new Dictionary<string, int> { { "ba", 2 }, { "black", 1 }, { "sheep", 1 } };

        string[] array2 = { "a", "b", "a", "c", "b" };
        Dictionary<string, int> expected2 = new Dictionary<string, int> { { "a", 2 }, { "b", 2 }, { "c", 1 } };

        string[] array3 = { "c", "b", "a" };
        Dictionary<string, int> expected3 = new Dictionary<string, int> { { "c", 1 }, { "b", 1 }, { "a", 1 } };

        [TestMethod] //short technique doesnt work 
        public void WordCountTest()
        {
            WordCount wordCount = new WordCount();
            //Dictionary<string, int> result1,result2,result3 = wordCount.GetCount(array1,array2,array3);
            Dictionary<string, int> result1 = wordCount.GetCount(array1);
            Dictionary<string, int> result2 = wordCount.GetCount(array2);
            Dictionary<string, int> result3 = wordCount.GetCount(array3);


        }
    }
}
