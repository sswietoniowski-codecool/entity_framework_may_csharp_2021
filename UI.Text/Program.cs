using System;
using Data;

namespace UI.Text
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyContext companyContext = new CompanyContext();

            var employees = companyContext.Employees;

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
