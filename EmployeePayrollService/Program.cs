﻿namespace EmployeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");
            EmployeeModel model = new EmployeeModel();
            EmployeeRepo.EmpDatabase();
        }
    }
}