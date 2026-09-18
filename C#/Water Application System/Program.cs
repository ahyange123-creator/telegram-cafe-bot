namespace Water_Application_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double GrossSalary, Tax = 0, NetSalary = 0, DoubleTaxRate, DoubleDeduction, TaxPercentage = 0; 
            Console.WriteLine("Salary Tax Application");
            Console.Write("GrossSalary:= ");
            GrossSalary = double.Parse(Console.ReadLine());
         
            if(GrossSalary<0)
            {
                Console.WriteLine("Invalid data input of number");
              } 
   
            else
            {
                Tax = (GrossSalary * TaxRate) - Deduction;

                if (usedNum >= 0 && usedNum <= 7)
                {
                    payment = usedNum * 350;

                }
                else if (usedNum > 7 && usedNum <= 22)
                {
                    payment = (350 * 7) + ((usedNum - 7) * 550);
                }
                else if (usedNum > 2 && usedNum <= 47)
                {
                    payment = (350 * 7) + +(15 * 550) + ((usedNum - 22) * 960);

                }
                else if (usedNum > 47 && usedNum <= 97)
                {
                    payment = (350 * 7) + +(15 * 550) + (25 * 550) + ((usedNum - 47) * 1200);
                }
                else if (usedNum > 97 && usedNum <= 197)
                {
                    payment = (350 * 7) + +(15 * 550) + (25 * 550) + (50 * 1200) + ((usedNum - 97) * 1900);
                }else if (usedNum > 197)
                {
                    payment = (350 * 7) + +(15 * 550) + (25 * 550) + (50 * 1200) + (50 * 1200)  + ((usedNum - 197) * 2200);
                }
                Console.WriteLine("Payment as R:" + payment.ToString("#,###.00") + "R");
                Console.WriteLine("Payment as $:" + (payment/4000).ToString("#,###.00") + "$");
                Console.ReadKey();
            }
               
        }
    }
}
