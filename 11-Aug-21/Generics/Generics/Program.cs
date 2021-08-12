using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpoyeeDetails<int, string> employeeDetails = new EmpoyeeDetails<int, string>();
            employeeDetails.AddEmployee(1002, "Chandler");
            employeeDetails.AddEmployee(1004, "Monica");
            employeeDetails.AddEmployee(1001, "Rachel");
            employeeDetails.AddEmployee(1003, "Joey");
            employeeDetails.AddEmployee(1006, "Ross");
            employeeDetails.RemoveEmployee(1002);
            employeeDetails.SortEmployee();
            employeeDetails.AddEmployee(1005, "Pheobe");
            employeeDetails.display();
            Console.ReadKey();
        }
    }

    class EmpoyeeDetails<k,v>
    {
        Dictionary<int, string> employee = new Dictionary<int, string>();
            

        public void AddEmployee(int id,string name)
        {
            employee.Add(id, name);
        }

        public void RemoveEmployee(int id)
        {
            employee.Remove(id);
        }

        public void SortEmployee()
        {
            var list = employee.Keys.ToList();
            list.Sort();

            foreach(var key in list)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
        }

        public void display()
        {
            foreach(var i in employee)
            {
                Console.WriteLine("Key : " + i.Key + ", Value : " + i.Value);
            }
        }
    }
}
