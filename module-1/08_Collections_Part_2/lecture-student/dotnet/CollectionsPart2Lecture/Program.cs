using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();
			//what kind of dictionary
			//vending machine item
				//key //value
			Dictionary<int, string> contentsOfVM = new Dictionary<int, string>() 
			{ 
				{ 512, "cheetos" }, 
				{ 1024, "flaming hots" } 
			};
			contentsOfVM.Add(4, "Skittles");
			contentsOfVM.Add(4, "Skittles");
            if (contentsOfVM.ContainsKey(4))
            {
				//pick
            }
            else
            {
				//ok to add the key
            }

			//adding

			//removing

			bool didWeRemoveNotExists = contentsOfVM.Remove(555);
			bool didWeRemoveExists = contentsOfVM.Remove(4);

            //looping //this is how we loop through
            foreach (KeyValuePair<int, string> content in contentsOfVM)
            {
				Console.WriteLine($"Our Vending Machine has {content.Value} at slot {content.Key}");
            }
			string item = contentsOfVM[4];
			//changing values
		}
		//return type method name parameters?
		static bool ContainsKey(Dictionary<int, string> dictionaryToCheck, int keyToCheck)
        {
			//contentsOfVM are out of scope
			//return dictionaryToCheck.ContainsKey(keyToCheck); //another way to do this
			bool containsKey = false;
            if (dictionaryToCheck.ContainsKey(keyToCheck))
            {
				containsKey = true;
            }

			//return dictionaryToCheck.ContainsKey(keyToCheck);
        }
	}
}
