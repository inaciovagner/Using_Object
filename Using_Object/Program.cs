using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Object
{
    public class Employee
    {
        public int id;
        public String name;
    }
    class EmployeeDetail
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.id = 20;
            emp.name = "John Smith";
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);
        }
    }
}
