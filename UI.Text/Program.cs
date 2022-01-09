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

            //Employee newEmployee = new Employee {FirstName = "Ktoś2", LastName = "Nowy2"};
            //companyContext.Employees.Add(newEmployee);

            var employee = companyContext.Employees.Find(2);
            employee.FirstName = "Jan";
            //companyContext.Employees.Update(new Employee { Id = 7, FirstName = "Jan"});
            //companyContext.Employees.Remove(new Employee { Id = 7 });
            Employee newEmployee = new Employee { FirstName = "Ktoś3", LastName = "Nowy3" };
            companyContext.Add(newEmployee);

            //var employeeToBeRemoved = companyContext.Employees.Find(6);
            //companyContext.Employees.Remove(employeeToBeRemoved);
            companyContext.SaveChanges();
        }
    }
}
