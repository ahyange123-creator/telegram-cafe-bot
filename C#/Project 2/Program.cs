namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Km, result;
            Console.WriteLine("Convert Km to M2");
            Console.Write("Enter Km");
            Km = Convert.ToDouble(Console.ReadLine());
            result = Km * 1000;

            Console.WriteLine(Km + " Km= " + result + "M ");
            Console.ReadKey();


        }
    }
}


           