using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    /* `year`: indicates the year that the car was manufactured.
     `make`: indicates the make of the car.
     `is classic car`: indicates if the car is a classic car.
     `age`: indicates the age (in years) of the car from the current year.
    */
    public class Car
    {
        public int YearManufactured { get; set; }
        public string MakeModel { get; set; }
        public bool IsClassicCar { get; set; }
        public int Age { get; set; }
        public Car (int year, string make, bool isClassic)
        {
            YearManufactured = year;
            MakeModel = make;
            IsClassicCar = isClassic;
            //age in years is current time minus yearmanufactured
            //DateTime.Now property
            Age = (DateTime.Now.Year - year);
        }
        //Create a method to determine if a car must receive an e-check using an input parameter: `int yearToCheck`.
        //bool bc it either it does or doesnt
        public bool NeedsCheck(int yearToCheck)
        {   /*Return true under the following conditions:
            Even-model year vehicles must be tested if `yearToCheck` is even.
            Odd-model year vehicles must be tested if `yearToCheck` is odd.
            */
            bool needsChecked = false;
            if ((YearManufactured % 2 == 0 && yearToCheck % 2 ==0) || (YearManufactured % 2 != 0 && yearToCheck % 2 != 0))
            {
                /** Return false if an e-check isn't needed or the car is exempt:
                A vehicle is exempt if it's under 4 years of age.
                A vehicle is exempt if it's over 25 years of age.
               Classic cars are always exempt.
                */
                if (Age > 4 && Age < 25 && IsClassicCar == false)
                {
                    needsChecked = true;
                }
            }
            return needsChecked;
        }


    }
}
