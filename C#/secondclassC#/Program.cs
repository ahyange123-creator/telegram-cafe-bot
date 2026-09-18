namespace secondclassC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money, result = 0;
            int exRate;

            Console.WriteLine("Exchange money from Dollar to Riel");
            Console.Write("Money:");
            money=Convert. ToDouble(Console.ReadLine());
            Console.Write("Exchange Rate:");
            exRate = Convert.ToInt32(Console.ReadLine());
            result = money * exRate;
            Console.WriteLine("Your money  is " + result.ToString("###.00") + "R");
            Console.ReadKey();


          



        }


   
       
        
           
    }
}
