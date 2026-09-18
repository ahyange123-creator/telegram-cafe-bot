namespace Salary_Tax_Application_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grossSalary; int child; int wife; double childbonus; double wifebonus;
            double grossSalarytTax; double taxRate; double payback; double tax; double netSalary;
            double bonus;
            Console.Write("Enter Gross Salary: ");
            grossSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of children: ");
            child =Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you have a wife?(1 for Yes, 0 for N): ");
            wife = Convert.ToInt32(Console.ReadLine());

            if ( child > 5)
            {
                child = 5;
            }
            if ( wife > 1)
            {
                wife = 1;
            }
            if (rossSalarytTax <= 1500000)
            {
                taxRate = 0;
                payback = 0;
            }
            else if (rossSalarytTax <= 2000000)
            {
                taxRate = 0.05;
                payback = 75000;
            }
            else if (rossSalarytTax <= 8500000)
            {
                taxRate = 0.10;
                payback = 172500;
            }
            else if (rossSalarytTax <= 12500000)
            {
                taxRate = 0.15;
                payback = 600000;
            }
            else
            {
                taxRate = 0.20;
                payback = 1225000;

            }
            childbonus = child * 150000;
            wifebonus = wife * 150000;
            bonus = childbonus + wifebonus;
            g = grossSalary - bonus;
            tax = (grossSalarytTax * taxRate) - payback;
            if ( tax < 0)
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


