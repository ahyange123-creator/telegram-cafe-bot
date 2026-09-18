namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 0, width, longs;
            Console.WriteLine("Rectangle Area");
            Console.WriteLine("Enter value of Width:");
            width =Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of Long:"); 
            longs = double. Parse(Console.ReadLine ());
            area = width * longs;
            Console.WriteLine("The result is " + area+"m3");
            Console. ReadKey();


        }
    }
}
