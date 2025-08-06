using System.Reflection.Metadata;
using System.Text;

namespace Day_3;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // var square = (int x) => x * x;

        // int number = 5;
        // int result = square(number);

        // System.Console.WriteLine($"Square of {number} is {result}");


        // var multiply = (int x, int y) =>
        // {
        //     int product = x * y;
        //     Console.WriteLine($"Multiplying {x} and {y} gives {product}");
        //     return product;
        // };

        // int result = multiply(4, 5);

        // int number = 5;
        // int result = FactorialRecursive(number);
        // Console.WriteLine($"Recursive: {number}! = {result}");

        // static int FactorialRecursive(int n)
        // {
        //     if (n == 1)
        //         return 1;
        //     else
        //         return n * FactorialRecursive(n - 1);

        // }

        // int invoiceNumber = 1201;
        // decimal productShares = 25.4568m;
        // decimal subtotal = 2750.00m;
        // decimal taxPercentage = .15825m;
        // decimal total = 3185.19m;

        // System.Console.WriteLine(@$"
        // Invoice #:      {invoiceNumber}
        // Product Shares: {productShares:F3}
        // Subtotal:       {subtotal:C2}
        // Taxes Charged:  {taxPercentage:P3}
        // Total:          {total:C2}");

        // string first = "Hello";
        // string second = "World";
        // string result = string.Format("{0} {1}!", first, second);
        // Console.WriteLine(result);

        // string input = "Pad this";
        // Console.WriteLine(input.PadLeft(12));

        // Console.WriteLine(input.PadRight(12));

        // Console.WriteLine(input.PadLeft(12, '-'));
        // Console.WriteLine(input.PadRight(12, '-'));

        // string paymentId = "769C";
        // string payeeName = "Mr. Stephen Ortega";
        // string paymentAmount = "$5,000.00";
        // var formattedLine = paymentId.PadRight(6);
        // formattedLine += payeeName.PadRight(24);
        // formattedLine += paymentAmount.PadLeft(10);
        // Console.WriteLine("1234567890123456789012345678901234567890");
        // Console.WriteLine(formattedLine);


        //         string customerName = "Ms. Barros";
        //         string currentProduct = "Magic Yield";
        //         int currentShares = 2975000;
        //         decimal currentReturn = 0.1275m;
        //         decimal currentProfit = 55000000.0m;
        //         string newProduct = "Glorious Future";
        //         decimal newReturn = 0.13125m;
        //         decimal newProfit = 63000000.0m;
        //         // Your logic here 
        //         System.Console.WriteLine($@"
        // Dear {customerName},
        // As a customer of our {currentProduct} offering we are excited to tell you about a new financial
        // product that would dramatically increase your return.

        // Currently, you own {currentShares:F2} shares at a return of {currentReturn:P2}.

        // Our new prodcut, {newProduct} offers a reutrn of {newReturn:P2}. Given your current volume, your
        // potential profit would be {newProfit:C2}
        // ");
        //         Console.WriteLine("Here's a quick comparison:\n");

        //         string comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C2}\n" +
        //                                     $"{newProduct}\t\t{newReturn:P2}\t{newProfit:C2}";
        //         comparisonMessage = currentProduct.PadLeft(10);
        //         comparisonMessage += currentReturn;

        //         //Your logic here

        //         Console.WriteLine(comparisonMessage);

        // string data = "12345John Smith          5000  3  ";

        // int startingPosition = data.IndexOf("J");
        // int closingPosition = data.LastIndexOf("5");
        // int length = closingPosition - startingPosition;
        // data = data.Remove(startingPosition, length);
        // Console.WriteLine(data);

        // string message = "This--is--ex-amp-le--da-ta";

        // message = message.Replace("--", " ");
        // message = message.Replace("-", "");



        // const string opneHeader = "<h2>";
        // const string openSpan = "<span>";
        // const string closedHeader = "</h2>";
        // const string closedSpan = "</span>";

        // const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        // string quantity = "";
        // string output = "";
        // // Your work here
        // const string openDiv = "<div>";
        // const string closedDiv = "</div>";

        // int openingPosition = input.IndexOf(openDiv);
        // int closingPosition = input.IndexOf(closedDiv);

        // openingPosition += openDiv.Length;
        // int length = closingPosition - openingPosition;
        // System.Console.WriteLine(input.Substring(openingPosition, length));


        // Console.WriteLine(quantity);
        // Console.WriteLine(output);

        // StringBuilder sb = new StringBuilder();
        // for (int i = 0; i < 50; i++)
        // {
        //     sb.Append(i).Append(",");
        // }

        // Console.WriteLine(sb);

        // StringBuilder sb = new StringBuilder("hello, world");
        // sb.Replace("world", "C#");
        // sb.Remove(5, 1);

        // Console.WriteLine(sb);

        // #1 the ourAnimals array will store the following: 
        string animalSpecies = "";
        string animalID = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";
        //Add Suggested Donation Data
        string suggestedDonation = "";

        // #2 variables that support data entry 
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";
        decimal decimalDonation = 0.00m; //Donations

        // #3 array used to store runtime data, there is no persisted data 
        string[,] ourAnimals = new string[maxPets, 7];

         // #4 create sample data ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    suggestedDonation = "85.00";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "gus";
                    suggestedDonation = "49.99";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "snow";
                    suggestedDonation = "40.00";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "lion";
                    suggestedDonation = "";
                    break;

                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    suggestedDonation = "";
                    break;
            }

            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            if (!decimal.TryParse(suggestedDonation, out decimalDonation))
            {
                decimalDonation = 45.00m; // Default if parsing fails
            }
            ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
        }



        // #5 display the top-level menu options
        do
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            // use switch-case to process the selected menu option
            switch (menuSelection)
            {
                case "1":
                    // List all pet info
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 7; j++) // UPDATED from 6 to 7
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();
                    break;

                case "2":
                    // Display all dogs with a specified characteristic"):
                    string dogCharacteristic = "";

                    while (dogCharacteristic == "")
                    {
                        System.Console.WriteLine("\nEnter one desired dog characteristic to search for:");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            dogCharacteristic = readResult.ToLower().Trim();
                        }
                    }

                    bool noMatchesDog = true;
                    string dogDescription = "";

                    //#6 Loop through the ourAnimals array to search for matching animals
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 1].ToLower().Contains("dog"))
                        {
                            //#7 combine physical and personality descriptions
                            dogDescription = ourAnimals[i, 4] + "" + ourAnimals[i, 5];

                            //check if it contains the search term
                            if (dogDescription.ToLower().Contains(dogCharacteristic))
                            {
                                Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                System.Console.WriteLine(dogDescription);
                                noMatchesDog = false;
                            }
                        }
                    }

                    if (noMatchesDog)

                    {
                        Console.WriteLine($"\nNone of our dogs are a match for: \"{dogCharacteristic}\"");
                    }

                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                default:
                    break;
            }

        } while (menuSelection != "exit");
    }
}



