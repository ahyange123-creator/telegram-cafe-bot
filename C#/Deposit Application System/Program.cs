
    namespace BankingEngine;

    public class TransactionEngine
    {
        public static void Main(string[] args)
        {
            // 1. Validate System Run Time
            int runTimes = 0;
            while (runTimes <= 0)
            {
                Console.Write("System run time: ");
                int.TryParse(Console.ReadLine(), out runTimes);
                if (runTimes <= 0)
                {
                    Console.WriteLine("Must enter an integer greater than 0.");
                }
            }

            int currentCycle = 0;

            // 2. Outer Batch Processing Loop
            while (currentCycle < runTimes)
            {
                Console.WriteLine($"\n--- Processing Application {currentCycle + 1} of {runTimes} ---");

                // Input: Deposit Amount
                decimal deposit = 0m;
                while (deposit <= 0m)
                {
                    Console.Write("Deposit: ");
                    decimal.TryParse(Console.ReadLine(), out deposit);
                    if (deposit <= 0m)
                    {
                        Console.WriteLine("Deposit must be positive.");
                    }
                }

                // Input: Currency Selection
                int currency = 0;
                while (currency is not (1 or 2))
                {
                    Console.WriteLine("Currency:\n1.Riel\n2.Dollar");
                    Console.Write("Please enter your transaction: ");
                    int.TryParse(Console.ReadLine(), out currency);
                    if (currency is not (1 or 2))
                    {
                        Console.WriteLine("Select either 1 or 2.");
                    }
                }

                // Input: Duration Selection
                int duration = 0;
                while (duration is < 1 or > 5)
                {
                    Console.WriteLine("Duration:\n1.1month\n2.2months\n3.3months\n4.6months\n5.12months");
                    Console.Write("Please enter your transaction: ");
                    int.TryParse(Console.ReadLine(), out duration);
                    if (duration is < 1 or > 5)
                    {
                        Console.WriteLine("Select an option from 1 to 5.");
                    }
                }

                // Rate and Duration Resolution
                string symbol = currency == 1 ? "R" : "$";
                (decimal interestRate, int months) = (currency, duration) switch
                {
                    (1, 1) => (0.035m / 12m, 1),
                    (1, 2) => (0.04m / 6m, 2),
                    (1, 3) => (0.045m / 4m, 3),
                    (1, 4) => (0.0675m / 2m, 6),
                    (1, 5) => (0.085m, 12),
                    (2, 1) => (0.03m / 12m, 1),
                    (2, 2) => (0.035m / 6m, 2),
                    (2, 3) => (0.04m / 4m, 3),
                    (2, 4) => (0.055m / 2m, 6),
                    (2, 5) => (0.08m, 12),
                    _ => (0m, 1)
                };

                // Calculations
                decimal grossInterest = deposit * interestRate;
                decimal taxDeduction = grossInterest * 0.06m; // 6% withholding tax
                decimal netInterest = grossInterest - taxDeduction;
                decimal totalPayout = deposit + netInterest;
                decimal monthlyYield = netInterest / months;

                // Output Display
                Console.WriteLine($"Interest: {netInterest:F2}{symbol}");
                Console.WriteLine($"Total Money: {totalPayout:F2}{symbol}");
                Console.WriteLine($"MonthlyInterest: {monthlyYield:F2}{symbol}");

                currentCycle++;
            }

            Console.WriteLine("\nAll transactions processed successfully.");
        }
    }


    

