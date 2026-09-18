namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Day, result;
            Console.WriteLine("Convert Time From day to second");
            Console.Write("Enter Day");
            Day = Convert.ToInt32(Console.ReadLine());
            result = Day * 86400;
            Console.WriteLine(Day + "Day=" + result + "s");
            Console.ReadKey();

        
            
        }
    }
}
