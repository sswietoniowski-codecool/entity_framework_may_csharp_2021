using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace UI.Text
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyContext companyContext = new CompanyContext();

            var employees = companyContext.Employees
                .Where(e => e.LastName.Contains("k")); // <- '%k%'
                //.Where(e => EF.Functions.Like(e.LastName, "K%"));
                //.ToList()
                //.Where(e => e.LastNameStartsWithK());

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            //var employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            //var employee = companyContext.Employees.Find(1);
            //Console.WriteLine(employee);
        }
    }
}
