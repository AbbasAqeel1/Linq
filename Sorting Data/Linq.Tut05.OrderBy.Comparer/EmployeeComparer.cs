using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQTut05.Shared;

namespace Linq.Tut05.OrderBy.Comparer
{
    internal class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee emp1, Employee emp2)
        {

            var emp1Year = emp1.EmployeeNo.Split('-')[0];
            var emp2Year = emp2.EmployeeNo.Split('-')[0];

            var emp1ID = emp1.EmployeeNo.Split('-')[2];
            var emp2ID = emp2.EmployeeNo.Split('-')[2];

            if(emp1Year == emp2Year)
            {
                return emp1ID.CompareTo(emp2ID);
            }
            else
            {
                return emp1Year.CompareTo(emp2Year);
            }

            
            
        }
    }
}
