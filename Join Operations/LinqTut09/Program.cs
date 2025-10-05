using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using LINQTut08.Shared;



namespace LinqTut09
{
    internal class Program
    {
        static void Main(string[] args)
        {


            RunJoinExample();
            RunJoinExampleUsingQuerySyntax();
            //RunGroupJoinExample();
            //RunGroupJoinExampleUsingQuerySyntax();
            Console.ReadKey();
        }

        private static void RunJoinExampleUsingQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();


            var result = from employee in employees
                         join department in departments

                         on employee.DepartmentId equals department.ID
                         select new EmployeeDto
                         {
                             Name = employee.FirstName + " " + employee.LastName,
                             DepartmentName = department.Name
                         };
                        

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name.PadRight(20,' ')}, {item.DepartmentName}");
            }
        }

        private static void RunJoinExample()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();

            //using method 
            var result = employees.Join(departments, emp => emp.DepartmentId, dept => dept.ID,
                (emp,dept) => 
                new EmployeeDto{
                    Name = emp.FirstName + " " + emp.LastName,
                    DepartmentName = dept.Name}
                );

            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name.PadRight(20,' ')}, {item.DepartmentName}");
            }
        }

        private static void RunGroupJoinExample()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();

            //Using method syntax
            var result = departments.GroupJoin(employees, dep => dep.ID, emp => emp.DepartmentId,


                (dep, emp) => new DepartmentGroup
                {
                    DepartmentName = dep.Name,
                    Employees = employees.Select(x => x.FirstName + " " + x.LastName).ToList()
                }
            );

            foreach(var item in result)
            {
                Console.WriteLine($"------- {item.DepartmentName} -------");




                
                foreach(var employee in item.Employees)
                {
                    Console.WriteLine($"{employee}");
                }
            }
           
        }

        private static void RunGroupJoinExampleUsingQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();

            //using query syntax
            var result = from department in departments
                         join emp in employees on department.ID equals emp.DepartmentId into empgroup

                         select empgroup;

            foreach (var item in result)
            {
                Console.WriteLine($"------- Group -------");

                foreach (var employee in item)
                {
                    Console.WriteLine($"{employee}");
                }
            }

        }


    }
}
