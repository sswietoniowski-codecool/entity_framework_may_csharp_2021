using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Data;
using Domain;

namespace UI.Text
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyContext companyContext = new CompanyContext();

            //var employees = companyContext.Employees.Where(e => e.Id >= 2 && e.Id <= 4);

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //var employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            var employee = companyContext.Employees.Find(1);
            Console.WriteLine(employee);
        }
    }
}
