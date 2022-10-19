using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static float calSalary(float salary, int n)
        {
            for (int i = 0; i < n; i++)
            {
                salary = (salary/10) + salary;
            }
            return salary;
        }
        static float calMonth(float money, float rate)
        {
            float interest = money * rate / 100;
            float month = money/interest;
            return Convert.ToInt32(month);
        }
        static float calSalaryRecursion(float salary, int n)
        {
            float sum = salary;
            if (n == 0)
            {
                return salary;
            }
            else
            {
                n--;
                return sum = calSalaryRecursion(salary, n) / 10 + calSalaryRecursion(salary, n);
            }
        }
        
        static float calMonthRecursion(float money, float rate, int month = 0)
        {
            if (month * rate * money / 100 - money >= 0)
            {
                return month;
            }
            else
            {
                return calMonthRecursion(money, rate, month + 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Don't use Recursion --------------");
            Console.Write("Salary : ");
            float salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year : ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calSalary(salary, years));

            Console.Write("Money : ");
            float money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rate : ");
            float rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month = " + calMonth(money, rate));

            Console.WriteLine("\n-------------- Use Recursion --------------");
            Console.Write("Salary : ");
            float salaryRecursion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year : ");
            int yearRecursion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calSalaryRecursion(salaryRecursion, yearRecursion));

            Console.Write("Money : ");
            float moneyRecursion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rate : ");
            float rateRecursion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month = " + calMonthRecursion(moneyRecursion, rateRecursion));
        }
    }
}
