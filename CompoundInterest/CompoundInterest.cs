using System;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            const decimal rate = 0.0625m;
            const decimal vat = 0.925m;
            const decimal cot = 0.98m;
            Console.WriteLine("Welcome to the Compound Interest Calculator");
            Console.WriteLine("Note: This Compound Interest Calculator is compounded monthly\n");
            Console.WriteLine("Please enter your Account Type:");
            var accountType = Console.ReadLine().ToLower();
            Console.WriteLine("Please Input the Principal Amount in Dollars: " );
            int principal = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input the time in years that the Principal Amount would be invested or borrowed for:" );
            int time = int.Parse(Console.ReadLine());

            decimal leftCalc =  (1 + (rate / 12));
            decimal rightCalc = time * 12;
            decimal Result = (decimal)(principal * (Math.Pow((double)leftCalc, (double)rightCalc)));

            switch (accountType)
            {
                case "savings":
                    Result = Result * vat;
                    break;
                case "current":
                    Result = Result * cot;
                    break;
                case "dom":
                    Result = Result * cot;
                    break;
                case "student":
                    Result = Result * vat * cot;
                    break;
                case "dollar":
                    Console.WriteLine("Please enter the dollar multiplier");
                    decimal multiplier = decimal.Parse(Console.ReadLine());
                    Result = Result * multiplier;
                    break;
                
            }

            Console.WriteLine("\n Your Investment or loan balance after {0} years is {1:C}", time, Result);
            Console.ReadLine();

        }
    }
}
