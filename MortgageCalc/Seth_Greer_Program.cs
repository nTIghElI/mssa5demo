using System.Runtime.CompilerServices;

namespace MortgageCalc;

class Program
{
    static void Main(string[] args)
    {
        // //Welcome & initializer
        // Console.WriteLine("Hello and welcome to your personalized home loan calculator. Guarenteed to help you with your financial situation!\nWhat is your name?");
        // string? userName = Console.ReadLine();
        // Console.Clear();
        // System.Console.WriteLine($"Welcome {userName}");

        // //Get user inputs
        // System.Console.WriteLine("In order to guarentee to most up to date accuracy for your personalized home loan I will need a few inputs.\nAre you ready?");
        // string? userReady = Console.ReadLine()?.ToLower().Trim();
        // if (userReady == "y" || userReady == "yes")
        //     System.Console.WriteLine("Great! Let's start");
        // else
        //     System.Console.WriteLine("That's too bad, let's start anyway.");

        //Price of the Home:
        Console.Clear();
        System.Console.WriteLine("Let's start with the purchase price of the Home.\nPlease input the price of the home:");

        //I can double check to make sure that the number is correct before moving on.
        int homePrice;
        while (true)
        {
            Console.Write("Price of your home: $ ");
            string? inputHomePrice = Console.ReadLine()?.Trim();

            if (inputHomePrice != null && int.TryParse(inputHomePrice, out homePrice))
                break; // Exit loop when input is valid

            Console.WriteLine("Invalid input. Please try again. Remember just the numbers please. (Don't worry about entering ','; just the number please.)");
        }


        Console.Clear();
        Console.WriteLine($"Great! You want to buy a home for {homePrice}, now let's calculate the type of loan.\nDo you want a fixed-rate (15-year or 30-year loan) or an adjustable-rate?");

        // Declare loanType outside the loop
        string loanType = "";

        while (true)
        {
            Console.Write("Loan type: 'fixed-rate' or 'adjustable-rate': ");
            string? inputLoanType = Console.ReadLine()?.Trim().ToLower();

            if (inputLoanType != null && inputLoanType.Contains("fixed"))
            {
                Console.WriteLine("You've selected a fixed-rate loan.");
                loanType = "fixed";
                break;
            }
            else if (inputLoanType != null && inputLoanType.Contains("adjustable"))
            {
                Console.WriteLine("You've selected an adjustable-rate loan.");
                Console.WriteLine("Adjustable-rate loans are not yet supported. This feature is still under development.");
                Console.WriteLine("Please check back in a future update.");
                loanType = "adjustable";
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again. Input either 'fixed' or 'adjustable'.");
            }
        }
        // I can now use loanType in the rest of my logic
        int loanRate = 1;
        if (loanType == "fixed")
        {
            Console.Clear();
            System.Console.WriteLine("Since you selected a fixed-rate loan, please specify the periods of the loan.\nFor example 15-years or 30-years are the most common.");

            while (true)
            {
                string? inputLoanRate = Console.ReadLine()?.Trim();
                if (inputLoanRate != null && int.TryParse(inputLoanRate, out loanRate))
                    break; // Exit loop when input is valid
                else
                    System.Console.WriteLine("Please input a valid loan rate. 15-year and 30-year are most common. Just type in the number.");
            }
        }
        else
            System.Console.WriteLine("Please wait while our apps is being updated to support a variable rate loan");

        //I have home price, Loan type, and Loan rate. I still need Term payment and monthly income.
        //Term payment
        string[] validTermPayment = { "monthly", "biweekly", "semimonthly", "weekly", "quarterly", "annually", "daily" };
        int termPayment = 1;

        while (true)
        {
            if ((loanType == "fixed"))
            {
                Console.Clear();
                Console.WriteLine("Please input how often you intend to pay. Monthly is most common.");
                string? inputTermPayment = Console.ReadLine()?.Trim().ToLower();
                //should probably make this a switch case...
                if (inputTermPayment == "monthly" || inputTermPayment == "30")
                {
                    termPayment = 12;
                    break;
                }
                else if (inputTermPayment == "biweekley" || inputTermPayment == "biweekly" || inputTermPayment == "bi-weekley" || inputTermPayment == "bi-weekly")
                {
                    termPayment = 26;
                    break;
                }
                else if (inputTermPayment == "semimonthly" || inputTermPayment == "semi-monthly")
                {
                    termPayment = 24;
                    break;
                }
                else if (inputTermPayment == "weekly")
                {
                    termPayment = 52;
                    break;
                }
                else if (inputTermPayment == "quarterly")
                {
                    termPayment = 4;
                    break;
                }
                else if (inputTermPayment == "annually")
                {
                    termPayment = 1;
                    break;
                }
                else if (inputTermPayment == "daily")
                {
                    termPayment = 365;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                Console.WriteLine($"You have selected to make a payment every {termPayment} period(s).");
            }
            else
            {
                Console.WriteLine("Adjustable-rate loans are not yet supported. Update coming soon!");
                break;
            }
        }

        //Monthly Income
        decimal monthlyIncome = 0;
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("Now I'll need your monthly income: $ ");
            string? inputMonthlyIncome = Console.ReadLine()?.Trim();
            if (inputMonthlyIncome != null && decimal.TryParse(inputMonthlyIncome, out monthlyIncome))
            {
                System.Console.WriteLine($"Thank you, you've selected your monthly income as {monthlyIncome}");
                break;
            }
            else
                System.Console.WriteLine("Invalid input, please try again.");
        }

        //Down Payment
        Console.Clear();
        System.Console.WriteLine("Do you intend to make a down Payment? Y/N");
        string downPayment = "n";
        int downPaymentAmount = 0;
        while (true)
        {
            string? inputDownPayment = Console.ReadLine()?.Trim().ToLower();
            if (inputDownPayment != "y" && inputDownPayment != "n")
            {
                System.Console.WriteLine("Please input either Y/N");
            }
            else if (inputDownPayment == "y")
            {
                downPayment = "y";
                System.Console.WriteLine("That is a good idea to make a down payment. This will help you avoid additional expenses.");
                while (true)
                {
                    System.Console.WriteLine("Please type in how much you want to pay down");
                    string? inputDownPaymentAmount = Console.ReadLine()?.Trim();
                    if (int.TryParse(inputDownPaymentAmount, out downPaymentAmount))
                    {
                        Console.Clear();
                        System.Console.WriteLine($"You are planning to pay {downPaymentAmount} as your down payment");
                        break;
                    }
                    else
                        System.Console.WriteLine("Invadlid input, please type in a number as your down payment.");
                }
                break;
            }
            else
            {
                downPayment = "n";
                break;
            }
        }


        //now I have monthlyIncome, termPayment, loanRate, homePrice, and userName.
        //I need to create method to estimate loan then write conditional for approve or deny
        //Calculate Loan Amount
        decimal baseLoanAmount = homePrice - downPaymentAmount;
        decimal originationFee = baseLoanAmount * 0.01m;
        decimal closingCosts = 2500m;

        decimal totalLoanAmount = baseLoanAmount + originationFee + closingCosts;
        System.Console.WriteLine($"Based on your inputs, I recommend that you get a ${totalLoanAmount} for your loan to cover all estimated costs.");

        //Loan Insurance
        System.Console.WriteLine("Now since I've crunched the numbers and have an estimated Loan for you. To finalize this process I will need a few more details.");
        System.Console.WriteLine("Please type in the current market value of your home. This will likely be different from the purchase price of the home.\nThis will be used to calculate if Loan insurance will be needed.\nMarket value of your home:");
        //string inputMarketValue;
        int marketValue;
        while (true)
        {
            string? inputMarketValue = Console.ReadLine();
            if (int.TryParse(inputMarketValue, out marketValue))
            {
                Console.Clear();
                System.Console.WriteLine($"Current market value of your home is ${marketValue}");
                break;
            }
            else
                System.Console.WriteLine("Invalid input, please type in the current market value for your home.");
        }
        decimal loanInsurance = 0;
        if (downPaymentAmount < (marketValue * .1))
        {
            System.Console.WriteLine("Due to low initial equity, you'll be required to purchase loan insurance. Consider putting a higher down payment if you want to avoid this.");
            int loanMarketDif = (int)totalLoanAmount - marketValue;
            if (loanMarketDif < 0)
            {
                loanMarketDif = 0;
                loanInsurance = (decimal)(totalLoanAmount * .1m) / termPayment + (decimal)(loanMarketDif);
            }
            else
                loanInsurance = (decimal)(totalLoanAmount * .1m) / termPayment + (decimal)(loanMarketDif);
        }
        else
            System.Console.WriteLine("I have great news, loan insurance isn't required for you!");

        int homeEquity = Math.Max(0, (homePrice - marketValue)) - downPaymentAmount;

        //HOA Fees
        Console.Clear();
        System.Console.WriteLine("Please type in your annual HOA fee.");
        string? inputHOA = Console.ReadLine();
        int hoaFee = Converter.ConverToInt(inputHOA);
        System.Console.WriteLine($"You'll have HOA fees of {hoaFee / termPayment} every payment");

        //Escrow
        decimal propertyTax = marketValue * .0125m;
        decimal homeownersInsurance = marketValue * .0075m;
        decimal escrowPayments = (propertyTax + homeownersInsurance) / 12;

        //Annual Interest Rate
        Console.Clear();
        System.Console.WriteLine("Please type in your annual interest rate.");
        string? inputInterest = Console.ReadLine();
        decimal annualInterest = Converter.ConvertToDec(inputInterest);
        System.Console.WriteLine($"You input an annual interest rate of {annualInterest}%.");
        //monthly Interst Rate
        decimal monthlyInterest = annualInterest / 100 / termPayment;

        //Loan payment
        int totalPayments = loanRate * termPayment;

        decimal monthlyPrincipalAndInterest = totalLoanAmount * (monthlyInterest * (decimal)Math.Pow(1 + (double)monthlyInterest, totalPayments)) / ((decimal)Math.Pow(1 + (double)monthlyInterest, totalPayments) - 1);
        decimal monthlyHOA = hoaFee / termPayment;
        decimal monthlyLoanInsurace = loanInsurance / termPayment;
        decimal estimatedMonthlyPayment = monthlyPrincipalAndInterest + monthlyHOA + monthlyLoanInsurace + escrowPayments;
        System.Console.WriteLine($"You have an estimated loan payment of {estimatedMonthlyPayment:C2} each payment period.");

        //Approval or denial - Loan Payment = P * (r / n) * [(1 + r / n)^n(t)] / [(1 + r / n)^n(t) - 1]
        //decimal actualLoanPayment = (decimal)totalLoanAmount * (interest / termPayment) * ((1 + interest / termPayment) ^ termPayment(loanRate) - 1);
        //decimal actualLoanPayment = interest / termPayment * (decimal)Math.Pow((double)(1 + interest / termPayment), termPayment * loanRate) * totalLoanAmount / ((decimal)Math.Pow((double)(1 + interest / termPayment), termPayment * loanRate) - 1);

        if (estimatedMonthlyPayment >= (decimal)(monthlyIncome * .25m))
        {
            System.Console.WriteLine("I'm sorry but your loan has been denied.");
        }
        else
        {
            Console.Clear();
            System.Console.WriteLine($"Congragulations, you're loan of ${totalLoanAmount} has been approved!");
            Console.WriteLine(" Mortgage Summary:");
            Console.WriteLine($"- Monthly Principal & Interest: {monthlyPrincipalAndInterest:C2}");
            Console.WriteLine($"- Monthly Loan Insurance: {monthlyLoanInsurace:C2}");
            Console.WriteLine($"- Monthly HOA Fee: {monthlyHOA:C2}");
            Console.WriteLine($"- Monthly Escrow: {escrowPayments:C2}");
            Console.WriteLine($" Total Estimated Monthly Payment: {estimatedMonthlyPayment:C2}");

            Console.WriteLine($"\n Home Price: {homePrice:C0}");
            Console.WriteLine($" Loan Term: {loanRate} years with {termPayment} payments per year");
            Console.WriteLine($" Down Payment: {homeEquity:C0}");
            Console.WriteLine($" Loan Insurance: {loanInsurance:C2} annually");
            Console.WriteLine($" HOA Fees: {hoaFee:C2} annually");

            Console.WriteLine($"\n Total Loan Amount (after fees): ${totalLoanAmount:F2}");
            Console.WriteLine($" Interest Rate: {annualInterest}% annually");
        }

        System.Console.WriteLine("\nThank you for using our personalized home loan app. Please provide feedback on your experience.");




        

    }
}

public static class Converter
{
    public static int ConverToInt(string? input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
            return 0;
    }

    public static decimal ConvertToDec(string? input)
    {
        if (decimal.TryParse(input, out decimal result))
        {
            return result;
        }
        else
            return 0;
    }
}

public static class Calculator
{
    public static decimal CalculatedLoanPayment(decimal totalLoanAmount, decimal interest, int termPayment, int loanRate)
    {
        decimal ratePerPeriod = interest / termPayment;
        int totalPayments = termPayment * loanRate;
        double baseValue = (double)(1 + ratePerPeriod);
        double exponent = totalPayments;
        double powerResult = Math.Pow(baseValue, exponent);
        decimal numerator = totalLoanAmount * ratePerPeriod * (decimal)powerResult;
        decimal denominator = (decimal)powerResult - 1;
        return denominator != 0 ? numerator / denominator : 0;
    }

    public static decimal DecimalPow(decimal baseValue, int exponent)
    {
        if (exponent == 0) return 1m;

        decimal result = 1m;
        for (int i = 0; i < Math.Abs(exponent); i++)
        {
            result *= baseValue;
        }
        return exponent > 0 ? result : 1m / result;
    }
}
