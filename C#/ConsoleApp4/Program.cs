using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Programme
    {
        static void Main(string[] args)
        {
            double oldNum, newNum, powerused = 0, payment = 0, price = 0;
            Console.WriteLine("EDC Application System");
            Console.Write("Old Number");
            oldNum = double.Parse(Console.ReadLine());
            Console.Write("New Number");
            newNum = double.Parse(Console.ReadLine());

            if (oldNum < 0 || newNum < 0)
            {
                Console.WriteLine("Invalid data input of old or new number" +
                    "\nPlease try again to input it");
            }

            else if (newNum < oldNum)
            {
                Console.WriteLine("Invalid data input of old or new number" + "\nPlease try again to input it");
            }
            else
            {
                powerused = newNum - oldNum;
                if (powerused >= 0 && powerused < 11)
                {

                    price = 380;

                }
                else if (powerused >= 11 && powerused < 51)
                {

                    price = 480;
                }
                else if (powerused >= 51 && powerused < 201)
                {

                    price = 610;

                }
                else if (powerused >= 201)
                {

                    price = 730;
                }
                payment = price * powerused;
                Console.WriteLine("Power Used:" + powerused.ToString("#0.00") + "kW/h");
                Console.WriteLine("Payment:" + payment.ToString("#,##0.00") + "R");
                Console.ReadKey();
            }




            }

        
        }
}
