namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int nmbrOfRacoons = 3;
            int nmbrOfRacoonsHome = 2;
            int nmbrOfRacoonsLeft = nmbrOfRacoons - nmbrOfRacoonsHome;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int nmbrOfFlowers = 5;
            int nmbrOfBees = 3;
            int nmbrOfExtraFlowers = nmbrOfFlowers - nmbrOfBees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lnlyPigeon = 1;
            int friendPigeon = 1;
            int totalFriends = lnlyPigeon + friendPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int intialOwls = 3;
            int newOwls = 2;
            int totalOwls = intialOwls + newOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorking = 2;
            int beaversSwiming = 1;
            int beaversLeft = beaversWorking - beaversSwiming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int sittingToucan = 2;
            int newToucan = 1;
            int totalToucans = sittingToucan + newToucan;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int treeSquirrels = 4;
            int treeNuts = 2;
            int extraSquirrels = treeSquirrels - treeNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            nickel = nickel * 2;
            double moneyFound = (quarter + dime + nickel) / 100.00;


            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int classBrier = 18;
            int classMacAdams = 20;
            int classFlannery = 17;
            int totalMuffins = classBrier + classMacAdams + classFlannery;


            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoCost = .24M;
            decimal whistleCost = .14M;
            decimal totalCost = yoyoCost + whistleCost;


            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int miniMallows = 10;
            int largeMallows = 8;
            int totalMallows = (miniMallows + largeMallows);

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHome = 29;
            int eleSchool = 17;
            int snowDiff = hiltHome - eleSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal currentMoney = 10;
            decimal toyTruckCost = 3;
            decimal pencilCaseCost = 2;
            decimal moneyRemaining = currentMoney - (toyTruckCost + pencilCaseCost);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int totalMarbles = 16;
            int lostMarbles = 7;
            int remainingMarbles = totalMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int goalAmount = 25;
            int currentAmount = 19;
            int missingAmount = goalAmount - currentAmount;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int shelfedBooks = 38;
            int newBooks = 10;
            int totalBooks = shelfedBooks + newBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beelegs = 6;
            int amountOfBees = 8;
            int totalBeeLegs = (beelegs) * (amountOfBees);
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            int iceCreamCone = 99;
            int numIceCreamCones = 2;
            double totalIceCreamConeCost = (iceCreamCone * numIceCreamCones) / 100.00;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int borderRocks = 125;
            int currentRocks = 64;
            int missingRocks = borderRocks - currentRocks;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltMarbles = 38;
            int missingMarbles = 15;
            int marblesLeft = hiltMarbles - missingMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMiles = 78;
            int completedMiles = 32;
            int milesLeft = totalMiles - completedMiles;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int timeMorning = 90;
            int timeAfternoon = 45;
            int totalTimeShovel = timeMorning + timeAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totalHotDogs = 6;
            decimal hotDogCost = .50M;
            decimal hiltPayment = (totalHotDogs * hotDogCost);

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int moneyAmount = 50;
            int pencilCost = 7;
            int mostPurchasable = moneyAmount / pencilCost;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int numOrange = 20;
            int numRed = totalButterflies - numOrange;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal katesMoney = 1.00M;
            decimal candyCost = 0.54M;
            decimal changeBack = katesMoney - candyCost;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int marksTrees = 13;
            int addedTrees = 12;
            int totalTrees = marksTrees + addedTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysTillGma = 2;
            int hoursInDay = 24;
            int totalHours = daysTillGma * hoursInDay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimsCousins = 4;
            int gumPerCousin = 5;
            int totalGumNeeded = kimsCousins * gumPerCousin;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal dansMoney = 3.00M;
            decimal candybarCost = 1.00M;
            decimal moneyLeftOver = (dansMoney - candybarCost);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInLake = 5;
            int peoplePerBoat = 3;
            int totalPeople = boatsInLake * peoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int originalLegoCount = 380;
            int lostLegos = 57;
            int remainingLegos = originalLegoCount - lostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int plannedMuffins = 83, bakedMuffins = 35;
            int neededMuffins = plannedMuffins - bakedMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int differenceInCrayons = willysCrayons - lucysCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int totalPages = 22;
            int totalStickers = stickersPerPage * totalPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double totalCupcakes = 100;
            double totalChildren = 8;
            double cupcakesPerChild = (totalCupcakes / totalChildren);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int cookiesPerJar = 6;
            int totalCookies = 47;
            int cookiesWithoutJar = totalCookies % cookiesPerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int totalNeighbors = 8;
            int remainingCroissants = totalCroissants % totalNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int totalCookiesBaked = 276;
            int totalTraysNeeded = totalCookiesBaked / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int pretzelsPerServing = 12;
            int totalServings = totalPretzels / pretzelsPerServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int boxedLemonCakes = 53;
            int cakesLeftBehind = 2;
            int cupcakesPerBox = 3;
            int totalBoxedCupCakes = (boxedLemonCakes - cakesLeftBehind) / cupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int preparedCarrots = 74;
            int peopleAtBfast = 12;
            int remainingCarrots = (preparedCarrots % peopleAtBfast);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int bearsPerShelf = 7;
            int totalShelvesUsed = totalTeddyBears / bearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalPictures = 480;
            int picturesPerAlbum = 20;
            int totalAlbums = totalPictures / picturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalCards = 94;
            int cardsPerBox = 8;
            int totalBoxes = totalCards / cardsPerBox;
            int unfilledBox = totalCards % cardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalDistrBooks = 210;
            int totalShelvesRepaired = 10;
            int booksPerShelf = totalDistrBooks / totalShelvesRepaired;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double bakedCroissants = 17;
            double totalGuests = 7;
            double croissantsPerGuest = bakedCroissants / totalGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
            int totlFtPerRoom = (12 + 12 + 14 + 14);
            double billsAvg = (totlFtPerRoom) / 2.15;
            double jillsAvg = (totlFtPerRoom) / 1.90;
            double timeToPaintRooms = billsAvg + jillsAvg;
            double totlWallsPerFt = totlFtPerRoom * 5;
            double totlHourlyRate = totlWallsPerFt / timeToPaintRooms;

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper, ";
            string middleInitial = " B.";
            string fullName = lastName + firstName + middleInitial;
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int distanceBtwnNyChi = 800;
            int distanceTrainTraveled = 537;
            double prctDistComplete = (double)distanceTrainTraveled / (double)distanceBtwnNyChi;
            int prctTripComplete = (int)(prctDistComplete * 100);
        }
    }
}
