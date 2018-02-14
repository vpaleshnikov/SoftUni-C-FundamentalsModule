using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    public static void Main()
    {
        var employees = new List<Employee>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var employeeInfo = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var employee = new Employee();
            employee.Name = employeeInfo[0];
            employee.Salary = decimal.Parse(employeeInfo[1]);
            employee.Position = employeeInfo[2];
            employee.Department = employeeInfo[3];

            if (employeeInfo.Length == 5)
            {
                if (employeeInfo[4].Contains("@"))
                {
                    employee.Email = employeeInfo[4];
                }
                else
                {
                    employee.Age = int.Parse(employeeInfo[4]);
                }
            }
            else if (employeeInfo.Length > 5)
            {
                employee.Email = employeeInfo[4];
                employee.Age = int.Parse(employeeInfo[5]);
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.Department)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.Salary),
                Employees = e.OrderByDescending(emp => emp.Salary)
            })
            .OrderByDescending(a=> a.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");

        foreach (var employee in result.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
        }
    }
}