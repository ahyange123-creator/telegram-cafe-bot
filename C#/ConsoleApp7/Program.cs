namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String days, months;

            Console.WriteLine("Day: ");
            days = Console.ReadLine();
            months = Console.ReadLine().ToLower();



            switch (days)
            {
                case "1":
                    Console.WriteLine("Your day is Monday");
                    break;
                case "2":
                    Console.WriteLine("Your day is Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Your day is Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Your day is Thursday");
                    break;
                case "5":
                    Console.WriteLine("Your day is Friday");
                    break;
                case "6":
                    Console.WriteLine("Your day is Saturday");
                    break;
                case "7":
                    Console.WriteLine("Your day is Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Day ");
                    break;

            }
            switch (months)
            {
                case "January":
                    Console.WriteLine("Your month is 1");
                    break;
                case "February":
                    Console.WriteLine("Your month is 2");
                    break;
                case "March":
                    Console.WriteLine("Your month is 3");
                    break;
                case "April":
                    Console.WriteLine("Your month is 4");
                    break;
                case "May":
                    Console.WriteLine("Your month is 5");
                    break;
                case "June":
                    Console.WriteLine("Your month is 6");
                    break;
                case "July":
                    Console.WriteLine("Your month is 7");
                    break;
                case "August":
                    Console.WriteLine("Your month is 8");
                    break;
                case "September":
                    Console.WriteLine("Your month is 9");
                    break;
                case "October":
                    Console.WriteLine("Your month is 10");
                    break;
                case "November":
                    Console.WriteLine("Your month is 11");
                    break;
                case "December":
                    Console.WriteLine("Your month is 12");
                    break;
                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
            Console.WriteLine("Your day is: " + days);
            Console.WriteLine("Your month is: " + months);
            Console.ReadKey();  


        }
    }
}

    

