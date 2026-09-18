namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grossSalary, netSalary = 0, tax = 0, taxPercentage = 0;
            Console.WriteLine("Salary Tax Application");
            Console.Write("Gross Salary:");
            grossSalary=double.Parse(Console.ReadLine());

            if(grossSalary < 0)
            {
                Console.WriteLine("Invalid Data Input of gross Salary\n" + "Please try again to input it");

            }
            else
            {
                if(grossSalary >=0 && grossSalary < 1500001)
                {
                    tax = 0;
                    taxPercentage = 0;


                }else if (grossSalary>= 1500001 && grossSalary < 2000001)
                {
                    tax = (grossSalary*0.05) - 75000;
                    taxPercentage = 5;

                }
                else if (grossSalary>= 2000001 && grossSalary < 8500001)
                {
                    tax = (grossSalary * 0.1) - 175000;
                    taxPercentage = 10;

                }
                else if (grossSalary<= 8500001 && grossSalary < 12500000)
                {
                    tax = (grossSalary * 0.15) - 600000;
                    taxPercentage = 15;

                } else if (grossSalary >= 12500000)
                {
                    tax = (grossSalary * 0.2) - 1125000;
                    taxPercentage = 20;
                }
                netSalary = grossSalary - tax;
                Console.WriteLine("Tax:" + tax.ToString("#,$$.,00") + "R");
                Console.WriteLine("Net Salary:" + netSalary.ToString("#,##0.00") + "R");
                Console.WriteLine("Tax Percentage:" + taxPercentage + "%");
                Console.ReadKey();  


            }
            
        }
    }
}
