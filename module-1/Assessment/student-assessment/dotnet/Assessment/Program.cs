using System;
using System.Collections.Generic;
using System.IO;

namespace Assessment
{
   public class Program
    {
        static void Main(string[] args)
        {   //call csc like in the capstone
            string fileName = "CarInput.csv";
            using StreamReader streamReader = new StreamReader($"{Environment.CurrentDirectory}\\{fileName}");
            Dictionary<string, Car> carClass = new Dictionary<string, Car>();
            
        }
    }
}
