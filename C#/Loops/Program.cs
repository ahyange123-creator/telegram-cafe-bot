namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, s; s = 0;
            Console.WriteLine("Enter the number you"+ "wish to add, enter 0 to quiet: ");
            do
            {
                k = Convert.ToInt32(Console.ReadLine());
                s = s + k;

            } while (k != 0);
            Console.WriteLine("The sum of the number entered is {0}", s);
            Console.ReadKey();

        

            


            
        }
    }
}
