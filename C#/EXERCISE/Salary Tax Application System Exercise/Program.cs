namespace Salary_Tax_Application_System_Exercise
{
    internal class Program
    {
     
       
            static void Main(string[] args)
            {
                double grossSalary; int child; int wife; double childbonus; double wifebonus;
                double grossSalaryTax; double taxRate; double payback; double tax; double netSalary;
                double bonus;
                Console.Write("Enter Gross Salary: ");
                grossSalary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number of children: ");
                child = Convert.ToInt32(Console.ReadLine());
              

                if (child > 5)
                {
                    child = 5;
                }
               
                childbonus = child * 150000;
                wifebonus =  150000;
                bonus = childbonus + wifebonus;
                grossSalaryTax = grossSalary - bonus;
            if (grossSalaryTax <= 1500000)
                {
                    taxRate = 0;
                    payback = 0;
                }
                else if (grossSalaryTax <= 2000000)
                {
                    taxRate = 0.05;
                    payback = 75000;
                }
                else if (grossSalaryTax  <= 8500000)
                {
                    taxRate = 0.10;
                    payback = 172500;
                }
                else if (grossSalaryTax <= 12500000)
                {
                    taxRate = 0.15;
                    payback = 600000;
                }
                else
                {
                    taxRate = 0.20;
                    payback = 1225000;

                }
                
                tax = (grossSalary * taxRate) - payback;
                if (tax < 0)
                {
                    tax = 0;
                }
                netSalary = grossSalary - tax;

                Console.WriteLine("Net Salary:" + netSalary.ToString("N2") + "R");
                Console.WriteLine("Tax:" + tax.ToString("N2") + "R");
                Console.ReadLine();
            }
    }
}
