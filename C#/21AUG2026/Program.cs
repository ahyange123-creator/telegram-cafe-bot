using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace _21AUG2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit, interest = 0, totalInterest = 0, monthlyInterest = 0, interestrate = 0;
            int runTime, currency, duration;
            string currencyType = "";
            while (true)
            {
                Console.WriteLine("Deposit Application System");
                Console.WriteLine("Deposit:");
                deposit = double.Parse(Console.ReadLine());
                Console.WriteLine("Currency:");
                Console.WriteLine("1.Riel");
                Console.WriteLine("2.Dollar");
                Console.WriteLine("3.Yuan");
                Console.WriteLine("Please enter your transaction: ");
                currency = int.Parse(Console.ReadLine());
                Console.WriteLine("Duration: ");
                Console.WriteLine("1.12month");
                Console.WriteLine("2.24month");
                Console.WriteLine("3.36month");
                Console.WriteLine("4.48month");
                Console.WriteLine("5.72month");
                Console.WriteLine("Please enter your transaction: ");
                duration = int.Parse(Console.ReadLine());
                if (currency == 1)
                {

                    currencyType = "R";
                }
                {
                    if (duration == 1)
                    {
                        duration = 1;

                        interestrate = 0.035;
                    }
                    else if (duration == 2)
                    {
                        duration = 2;
                        interestrate = 0.04 * 2;

                    }
                    else if (duration == 3)
                    {
                        duration = 3;

                        interestrate = 0.04 * 3;
                    }
                    else if (duration == 4)
                    {
                        duration = 4;
                        interestrate = 0.09 * 4;
                    }
                    else if (duration == 5)
                    {
                        duration = 6;
                        interestrate = 0.10 * 6;
                    }

                    else if (currency == 2)

                        currencyType = "$";
                    if (duration == 1)
                    {
                        duration = 1;

                        interestrate = 0.035;
                    }
                    else if (duration == 2)
                    {
                        duration = 2;
                        interestrate = 0.03 * 2;
                    }
                    else if (duration == 3)
                    {
                        duration = 3;
                        interestrate = 0.06 * 3;
                    }
                    else if (duration == 4)
                    {
                        duration = 4;
                        interestrate = 0.09 * 4;

                    }
                    else if (duration == 5)
                    {
                        duration = 6;
                        interestrate = 0.1 * 6;

                    }

                    else if (currency == 3)

                        currencyType = "Yuan";
                    if (duration == 1)
                    {
                        duration = 1;

                        interestrate = 0.035;
                    }
                    else if (duration == 2)
                    {
                        duration = 24;
                        interestrate = 0.03 * 2;
                    }
                    else if (duration == 3)
                    {
                        duration = 36;
                        interestrate = 0.06 * 3;
                    }
                    else if (duration == 4)
                    {
                        duration = 48;
                        interestrate = 0.09 * 4;

                    }
                    else if (duration == 5)
                    {
                        duration = 72;
                        interestrate = 0.1 * 6;


                    }
                    else
                    {
                        Console.WriteLine("Invalid input currency");
                    }

                    interest = (deposit * interestrate) - ((deposit * interestrate) * 0.06);
                    totalInterest = deposit + interest;
                    monthlyInterest = interest / duration;
                    Console.WriteLine("Interest:" + interest.ToString("#.#0") + currencyType);
                    Console.WriteLine("TotalInterest:" + totalInterest.ToString("#.#0") + currencyType);
                    Console.WriteLine("Total monthly interest:" + monthlyInterest.ToString("#.#0") + currencyType);
                    string answer;
                    Console.WriteLine("Do you want to continue ? yes/no");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.Clear();
                        continue;

                    }
                    else if (answer == "no")
                    {
                        break;
                    }
                    Console.ReadKey();
                }


            }
        }
    }   }
        
    

