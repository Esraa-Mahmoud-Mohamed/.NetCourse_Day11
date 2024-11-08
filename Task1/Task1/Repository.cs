using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    public static class Repository
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>()
        {
            new Employee {Id=1,Name="Sara",Age=20,Salary=10234,DeptId=10},
            new Employee {Id=2,Name="Osama",Age=30,Salary=9234,DeptId=20},
            new Employee { Id = 3, Name = "Aya", Age = 29, Salary = 8234, DeptId = 20 },
            new Employee { Id = 4, Name = "Lara", Age = 28, Salary = 7234, DeptId = 30 },
            new Employee { Id = 5, Name = "Saeed", Age = 27, Salary = 6234, DeptId = 30 },
            new Employee { Id = 6, Name = "Mariem", Age = 26, Salary = 5234, DeptId = 20 },
            new Employee { Id = 7, Name = "Ahmed", Age = 25, Salary = 4234, DeptId = 20 },
            new Employee { Id = 8, Name = "Eman", Age = 24, Salary = 3234, DeptId = 10 },
            new Employee { Id = 9, Name = "Khatab", Age = 23, Salary = 2234, DeptId = 10 },
            new Employee { Id = 10, Name = "Ali", Age = 22, Salary = 1234, DeptId = 10 }
        };
    }
}
