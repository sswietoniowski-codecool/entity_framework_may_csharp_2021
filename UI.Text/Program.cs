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

            var employees = companyContext
                .Employees.Where(e => e.EmpId == 2)
                .Include(e => e.PassportInfo)
                .Include(e => e.Projects);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
