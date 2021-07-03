using System;

namespace NetSalary
{
    //You can add new tax when you add new function with parameter "gross value" and
    //body who calculate new tax in class CalculateTaxes. 


    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input gross value");

            var salary = double.Parse(Console.ReadLine());

            var result = salary;

            result -= CalculateTaxes.Tax(salary);

            result -= CalculateTaxes.SocialContributionse(salary);

            Console.WriteLine("Net salary: " + result.ToString("0.00"));

        }
    }
}
