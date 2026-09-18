namespace GB_to_MB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double GB, result;
            Console.WriteLine("Convert GB to MB");
            Console.Write("GB ");
            GB =Convert .ToDouble(Console.ReadLine());
            result = GB * 1024;

            Console.WriteLine(GB + "GB=" + result + "MB");
            Console.ReadKey();

           
        }
    }
}
