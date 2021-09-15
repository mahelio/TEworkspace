using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises;
            numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);


            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half = 0.5;

            Console.WriteLine(half);


            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name = "TechElevator";
            Console.WriteLine(name);


            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;




            Console.WriteLine(seasonsOfFirefly);




            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";

            Console.WriteLine(myFavoriteLanguage);


            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;

            Console.WriteLine(pi);



            /*
            7. Create and set a variable that holds your name.
            */
            string myName;

            myName = "Mustafa";



            Console.WriteLine(myName);





            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberButtons = 5;

            Console.WriteLine(numberButtons);



            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            short percentBattery;

            percentBattery = 93;

            Console.WriteLine(percentBattery);




            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int solutionTen;


            solutionTen = 121 - 27;

            Console.WriteLine();




            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double solutionEleven = 12.3 + 32.1;

            
            Console.WriteLine();



            /*
            12. Create a string that holds your full name.
            */
            string fullName = "Mustafa Abuhilal";

            Console.WriteLine();




            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string wordHello = "Hello,";

            string greeting = fullName + wordHello;


            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            greeting = greeting + "Esquire";

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            greeting += ", a cool guy";

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            int numberTwo = 2;
            string movie = "Saw" + numberTwo;
            Console.WriteLine(movie);

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            numberTwo++;
            Console.WriteLine(movie);


            /*
            18. What is 4.4 divided by 2.2?
            */
            double numberOne = 4.4 / 2.2;

            /*
            19. What is 5.4 divided by 2?
            */

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            double quotient = 5 / 2;
            Console.WriteLine(quotient);

            /*
            21. What is 5.0 divided by 2?
            */
            double quotientDouble = 5.0 / 2;
            Console.WriteLine(quotientDouble);

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal balance = 1234.56M;
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;




            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?
            */
            float bigNumber = 3 * 1000000000f;

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

            Console.ReadLine();
        }
    }
}
