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

        TellFortune();

        void TellFortune()
        {
            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
            string[]? fortunes = null;

            //assign random variable to good, bad, and neutral fortune
            Random random = new Random();
            int randomFortune = random.Next(3);
            switch (randomFortune)
            {
                case 0:
                    fortunes = bad;

                    break;
                case 1:
                    fortunes = neutral;
                    break;
                case 2:
                    fortunes = good;
                    break;
            }

            //combine text with space with either good, bad, or neutral
            System.Console.WriteLine("A fortune teller whispers the following words:");
            for (int i = 0; i < 3; i++)
            {
                System.Console.Write($"{text[i]} {fortunes[i]} ");
            }
            // foreach (string sentence in text)
            // {
            //     System.Console.WriteLine($"{sentence}");
            // }
            // foreach (string fortune in fortunes)
            // {
            //     System.Console.WriteLine($"{fortune}");
            // }
        }
    }
}
 




