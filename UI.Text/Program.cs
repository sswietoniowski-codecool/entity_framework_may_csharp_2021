﻿using System;
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

            //var employees = companyContext.Employees
            //    //.Where(e => e.LastName.Contains("k")); // <- '%k%'
            //    //.Where(e => EF.Functions.Like(e.LastName, "K%"));
            //    //.ToList()
            //    //.Where(e => e.LastNameStartsWithK());
            //    //.Where(e => e.LastName.StartsWith("K"));
            //    .Where(e => e.LastName != null);

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //var employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            //var employee = companyContext.Employees.Find(1);
            //var employee = companyContext.Employees.First();
            //var employee = companyContext.Employees
            //    .Where(e => e.Id >= 2)
            //    .OrderByDescending(e => e.Id)
            //    .Last();
            //var employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee);
            //employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee);
            //employee = companyContext.Employees.FirstOrDefault(e => e.Id == 1);
            //Console.WriteLine(employee);

            var employee = companyContext.Employees.Find(1);
            Console.WriteLine(employee);
            employee = companyContext.Employees.Find(1);
            Console.WriteLine(employee);
            employee = companyContext.Employees.Find(1);
            Console.WriteLine(employee);
        }
    }
}
