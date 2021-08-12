using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankBranch> bankBranches = new List<BankBranch>();

            bankBranches.Add(new BankBranch { BankName = "SBI", Area = "Alwarthirunagar" });
            bankBranches.Add(new BankBranch { BankName = "Axis", Area = "Valasaravakkam" });
            bankBranches.Add(new BankBranch { BankName = "PNB", Area = "Vadapalani" });

            List<BankManager> bankManagers = new List<BankManager>();

            bankManagers.Add(new BankManager { ManagerName = "Ross", BankName = "SBI", age = 27, maxPoint = 88 });
            bankManagers.Add(new BankManager { ManagerName = "John", BankName = "Axis", age = 37, maxPoint = 92 });
            bankManagers.Add(new BankManager { ManagerName = "Rithu", BankName = "Axis", age = 42, maxPoint = 83 });
            bankManagers.Add(new BankManager { ManagerName = "Dani", BankName = "PNB", age = 20, maxPoint = 75 });

            foreach (BankManager i in bankManagers)
            {
                Console.WriteLine(i.BankName + " branch manager is " + i.ManagerName);
            }

            Console.WriteLine();
            //-------
            var bankmanagersAbove30 = bankManagers.FindAll(x => x.age > 30);

            foreach (var age in bankmanagersAbove30)
            {
                Console.WriteLine("The managers name whose age is above 30: " + age.ManagerName);
            }

            Console.WriteLine();
            //----------
            var max_point = bankManagers.Max(point => point.maxPoint);

            var bankmanagersMaxPoint = bankManagers.FindAll(x => x.maxPoint == max_point);

            foreach (var maxpoint in bankmanagersMaxPoint)
            {
                Console.WriteLine("The bank manager who has maximum point: " + maxpoint.ManagerName);
            }
            Console.ReadKey();
        }
    }

    class BankBranch
    {
        public string BankName { get; set; }
        public string Area { get; set; }
    }

    class BankManager
    {
        public string ManagerName { get; set; }
        public int age { get; set; }
        public int maxPoint { get; set; }
        public string BankName { get; set; }

    }
}
