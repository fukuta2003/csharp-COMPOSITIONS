using System;
using System.Collections.Generic;
using System.Globalization;
using Compositions.Entities;
using Compositions.Entities.Enum;

namespace Compositions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name.....: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base salary.....:");
            double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(workerName, level, workerSalary, dept);

            Console.Write("How many contracts to this worker ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++) {

                Console.WriteLine("Enter #{0} contract data:",i);
                Console.Write("Date (DD/MM/YYYY)............:");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour...............:");
                double porhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours).............:");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, porhora, hours);
                worker.AddContracts(contract);
            }

            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2));
            int year = int.Parse(monthandyear.Substring(3));

            Console.WriteLine("============================");
            Console.WriteLine("NAME..................: " + worker.Name);
            Console.WriteLine("DEPARTMENT............: " + worker.Department);
            Console.WriteLine("INCOME FOR {0}/{1}....: " + worker.Income(year,month).ToString("N2",CultureInfo.InvariantCulture),month,year);

        }
    }
}
