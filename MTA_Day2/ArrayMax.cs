using MTA_Day2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public sealed class ArrayMax
    {
        static IDictionary<int, Greeting> greatingDict = new Dictionary<int, Greeting>
            {
                {10, new Greeting
                {
                    Content = "Tuyệt vời",
                    Benefit = 5
                } },
                {9, new Greeting
                {
                    Content = "Tuyệt vời",
                    Benefit = 5
                } },
                {8, new Greeting
                {
                    Content = "Tuyệt vời",
                    Benefit = 5
                } },
                {7, new Greeting
                {
                    Content = "Rất tốt",
                    Benefit = 3.5
                } },
                {6, new Greeting
                {
                    Content = "Tốt",
                    Benefit = 2
                } },
                {5, new Greeting
                {
                    Content = "Có cố gắng",
                    Benefit = .5
                } },
                {4, new Greeting
                {
                    Content = "Kém",
                    Benefit = -.5
                } },
                {3, new Greeting
                {
                    Content = "Rất kém",
                    Benefit = -1
                } },
                {2, new Greeting
                {
                    Content = "Rất kém",
                    Benefit = -1
                } },
                {1, new Greeting
                {
                    Content = "Rất kém",
                    Benefit = -1
                } },
                {0, new Greeting
                {
                    Content = "Rất kém",
                    Benefit = -1
                } },
            };
        private ArrayMax()
        {
        }

        public static void TinhThuong()
        {

            var employees = InputEmployees();

            foreach (var employee in employees)
            {
                var greeting = GetGreating(employee);
                if (greeting != null)
                {
                    employee.Salary = employee.Sales * greeting.Benefit;
                    Console.WriteLine(employee);
                    Console.WriteLine(greeting.Content + $" Benefit: {employee.Salary}");
                } else
                {
                    Console.WriteLine(employee);
                    Console.WriteLine("Nhap sai thong tin doanh so");
                }
            }

            // nhan vien co muc luong cao nhat
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nhan vien co muc luong cao nhat");
            foreach (var employee in employees.Where(e => e.Salary == employees.Max(x => x.Salary)))
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("So nhan vien co muc luong > 2000 la");
            Console.WriteLine(employees.Count(x => x.Salary > 2000));
        }

        private static Greeting GetGreating(Employee employee)
        {
            if (greatingDict.TryGetValue(employee.Sales / 1000, out Greeting value))
            {
                return value;
            } else
            {
                return null;
            }
        }

        private static IList<Employee> InputEmployees()
        {
            Console.WriteLine("Nhap so luong nhan vien: ");
            int number = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[number];
            for (int i = 0; i < number; i++)
            {
                employees[i] = InputEmployee(index: i);
            }

            return employees;
        }

        private static Employee InputEmployee(int index)
        {
            Console.WriteLine($"Nhap ten nhan vien thu {index + 1}: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Nhap tuoi nhan vien thu {index + 1}: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap doanh so nhan vien thu {index + 1}: ");
            int sales = int.Parse(Console.ReadLine());

            return new Employee
            {
                Name = name,
                Age = age,
                Sales = sales
            };
        }
    }

    class Greeting
    {
        public double Benefit { get; set; }
        public string Content { get; set; }
    }
}
