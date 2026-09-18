namespace Score_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double html; double java; double cSharp; double php; double sqlServer; Double totalScore; double average;
            String grade;
            Console.Write("Enter HTML Score: ");
            html = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Java Score: ");
            java = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter C# Score: ");
            cSharp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter PHP  Score: ");
            php = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter SQL Server Score: ");
            sqlServer = Convert.ToDouble(Console.ReadLine());
            totalScore = html + java + cSharp + php + sqlServer;
            average = totalScore / 5;
            if (average < 0)
            {
                grade = "Invalid grade";
            }
            else if (average < 50)
            {
                grade = "F";
            }
            else if (average < 60)
            {
                grade = "E";
            }
            else if (average < 70)
            {
                grade = "D";
            }
            else if (average < 80)
            {
                grade = "C";

            }
            else if (average < 90)
            {
                grade = "B";
            }
            else if (average <= 100)
            {
                grade = "A";
            }

            else
            {
                grade = "Invalid grade";
            }
            Console.WriteLine("Average Score:" + average + "%");
            Console.WriteLine("Grade:" + grade);
            Console.ReadLine();

        }
    }
}

