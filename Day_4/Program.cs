namespace Day_4;

class Program
{
    static void Main(string[] args)
    {
        //         Console.WriteLine("Hello, World!");
        //         //3 methods to validate an IP address

        //     }
        // }

        // // four numbers separated by dots;
        // public bool FourValidate(string ipAddress)
        //     {
        //         if (!string.IsNullOrEmpty(ipAddress))
        //             return false;

        //         string[] segments = ipAddress.Split(":");
        //         foreach (string segment in segments)
        //         {
        //             int.TryParse(segment, int number);
        //         }
        // }

        //     //4-segment leading zero check
        //     public bool ZeroValidate(string? ipAddress)
        //     {
        //         //need to split into 4;
        //         if (ipAddress.StartsWith("0") && !string.IsNullOrEmpty(ipAddress))
        //             return true;
        //         else
        //             return false;
        //     }

        //     public bool RangeValidate(string ipAddress)
        //     {
        //         if (!int.TryParse(ipAddress, out int number))
        //             return false;

        //         if (0 <= number && number <= 255)
        //             return true;
        //         else
        //             return false;
        // }


        // static void Main()
        // {
        //     string[] ipv4Strings = { "192.168.1.1", "01.2.3.4", "256.100.50.25", "192.168.1" };
        //     foreach (string ipv4String in ipv4Strings)
        //     {
        //         string[] numbers = ipv4String.Split(".");
        //         //call validate length against ipv4String
        //         bool validLength = ValidateLength(numbers);
        //         //call validate zeros against ipv4String
        //         bool validZeros = ValidateZeros(numbers);
        //         //call validate range against ipv4String
        //         bool validRange = ValidateRange(numbers);

        //         //if validation succeeds
        //         if (validLength && validZeros && validRange)
        //         {
        //             System.Console.WriteLine($"{ipv4String} is a valid IP address.");
        //         }
        //         else
        //         {
        //             System.Console.WriteLine($"{ipv4String} is not a valid IP address.");
        //         }


        //     }

        // }

        // static bool ValidateLength(string[] numbers)
        // {
        //     return numbers.Length == 4;
        // }

        // static bool ValidateZeros(string[] numbers)
        // {
        //     // return number.StartsWith("0");
        //     foreach (string number in numbers)
        //     {
        //         if (numbers.Length > 1 && number.StartsWith("0"))
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }

        // static bool ValidateRange(string[] numbers)
        // {
        //     foreach (string number in numbers)
        //     {
        //         if (!int.TryParse(number, out int num) || num < 0 || num > 255)
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }

        // TellFortune();

        // void TellFortune()
        // {
        //     string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        //     string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        //     string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        //     string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
        //     string[]? fortunes = null;

        //     //assign random variable to good, bad, and neutral fortune
        //     Random random = new Random();
        //     int randomFortune = random.Next(3);
        //     switch (randomFortune)
        //     {
        //         case 0:
        //             fortunes = bad;

        //             break;
        //         case 1:
        //             fortunes = neutral;
        //             break;
        //         case 2:
        //             fortunes = good;
        //             break;
        //     }

        //     //combine text with space with either good, bad, or neutral
        //     System.Console.WriteLine("A fortune teller whispers the following words:");
        //     for (int i = 0; i < 3; i++)
        //     {
        //         System.Console.Write($"{text[i]} {fortunes[i]} ");
        //     }
        // foreach (string sentence in text)
        // {
        //     System.Console.WriteLine($"{sentence}");
        // }
        // foreach (string fortune in fortunes)
        // {
        //     System.Console.WriteLine($"{fortune}");
        // }
        // }

        // Random random = new Random();
        // static int luck;
        // string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        // string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        // string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        // string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
        // static void Main()
        // {
        //     luck = random.Next(1, 4);
        //     TellFortune();

        // }

        // static void TellFortune()
        // {
        //     Console.WriteLine("A fortune teller whispers the following words:");
        //     string[] fortune = luck switch
        //     {
        //         1 => good,
        //         2 => neutral,
        //         _ => bad
        //     };
        //     for (int i = 0; i < 4; i++)
        //     {
        //         Console.Write($"{text[i]} {fortune[i]} ");
        //     }
        // }

        string[,] ourAnimals = new string[4, 5];

        // Sample data: [0] = ID, [1] = Species, [2] = Nickname, [3] = Physical Description, [4] = Personality
        ourAnimals[0, 0] = "d1"; ourAnimals[0, 1] = "dog"; ourAnimals[0, 2] = "lola";
        ourAnimals[0, 3] = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
        ourAnimals[0, 4] = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";

        ourAnimals[1, 0] = "d2"; ourAnimals[1, 1] = "dog"; ourAnimals[1, 2] = "gus";
        ourAnimals[1, 3] = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        ourAnimals[1, 4] = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";

        ourAnimals[2, 0] = "c1"; ourAnimals[2, 1] = "cat"; ourAnimals[2, 2] = "snowball";
        ourAnimals[2, 3] = "small white female weighing about 8 pounds. uses litter box.";
        ourAnimals[2, 4] = "friendly and playful, likes to climb curtains and sit on laps.";

        ourAnimals[3, 0] = "c2"; ourAnimals[3, 1] = "cat"; ourAnimals[3, 2] = "lucy";
        ourAnimals[3, 3] = "medium sized gray tabby female weighing about 12 pounds. uses litter box.";
        ourAnimals[3, 4] = "quiet and affectionate, likes to nap in sunny spots and purrs loudly.";

        bool exitRequested = false;

        while (!exitRequested)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine("1. List all of our current pet information");
            Console.WriteLine("2. Display all dogs with a specified characteristic");
            Console.Write("Enter your selection number (or type Exit to exit the program): ");
            string? userSelection = Console.ReadLine()?.ToLower();

            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("\nCurrent pet information:");
                    for (int i = 0; i < ourAnimals.GetLength(0); i++)
                    {
                        Console.WriteLine($"ID #: {ourAnimals[i, 0]}");
                        Console.WriteLine($"Species: {ourAnimals[i, 1]}");
                        Console.WriteLine($"Nickname: {ourAnimals[i, 2]}");
                        Console.WriteLine($"Physical description: {ourAnimals[i, 3]}");
                        Console.WriteLine($"Personality: {ourAnimals[i, 4]}\n");
                    }
                    Console.WriteLine("Press the Enter key to continue");
                    Console.ReadLine();
                    break;

                case "2":
                    string[] searchTerms = SearchToArray();
                    bool dogMatchFound = false;

                    for (int i = 0; i < ourAnimals.GetLength(0); i++)
                    {
                        if (ourAnimals[i, 0].ToLower() == "dog")
                        {
                            string dogName = ourAnimals[i, 1];
                            string description = (ourAnimals[i, 2] + " " + ourAnimals[i, 3]).ToLower();
                            bool currentDogMatched = false;

                            foreach (string term in searchTerms)
                            {
                                ShowSearchAnimation(dogName, term);

                                if (description.Contains(term))
                                {
                                    Console.WriteLine($"Our dog {dogName} matches your search for '{term}'!");
                                    currentDogMatched = true;
                                    dogMatchFound = true;
                                }
                            }

                            if (currentDogMatched)
                            {
                                Console.WriteLine($"Nickname: {dogName} (ID #: {ourAnimals[i, 4]})");
                                Console.WriteLine($"Physical description: {ourAnimals[i, 2]}");
                                Console.WriteLine($"Personality: {ourAnimals[i, 3]}\n");
                            }
                        }
                    }

                    if (!dogMatchFound)
                    {
                        Console.WriteLine($"None of our dogs are a match for: {string.Join(", ", searchTerms)}");
                    }

                    Console.WriteLine("Press the Enter key to continue");
                    Console.ReadLine();
                    break;

                case "exit":
                    exitRequested = true;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please enter 1, 2, or Exit.");
                    Console.WriteLine("Press the Enter key to continue");
                    Console.ReadLine();
                    break;
            }
        }


    }


    public static string[] SearchToArray()
    {
        Console.WriteLine("\nEnter one desired dog characteristic to search for:");
        string[]? searchTerm = Console.ReadLine()?.ToLower().Split(",");

        if (searchTerm == null)
            return new string[0];

        for (int i = 0; i < searchTerm?.Length; i++)
        {
            searchTerm[i] = searchTerm[i].Trim();
        }
        Array.Sort(searchTerm!); //alphabatize
        return searchTerm!;

    }

    public static void ShowSearchAnimation(string dogName, string term)
    {
        string[] searchingIcons = { ".  ", ".. ", "...", "...." };
        foreach (string icon in searchingIcons)
        {
            Console.Write($"\rSearching our dog Nickname: {dogName} for '{term}' {icon}");
            Thread.Sleep(300);
        }
        Console.WriteLine();
    }


}




