namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int k, cofie, n, run, j;
            k = j = 1;
            Console.WriteLine("System Run Time: ");
            run = int.Parse(Console.ReadLine());
            while (j <= 0)
            {
                cofie = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number coffiecient: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter N: ");
                k = 1;
                while (k <= n)
                {
                    Console.WriteLine(cofie + "x" + k + "=" + cofie * k);
                    k++;


                }
                Console.ReadKey();

            }
        }
    }
}


