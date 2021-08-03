//1.Create a static Class and access the methods in the main program
//2. Create a normal instance class but have few static methods and
//access them from the main program 
//3.  In a class have static properties and use them in the methods sections. 

class Practice
{
    static void Main()
    {
        Employee.EmployeeDetails();

        System.Console.WriteLine(Employee.EmpName);
        System.Console.WriteLine(Employee.EmpId);
        System.Console.WriteLine(Employee.companyName);

        System.Console.ReadKey();

    }
}

static class Employee
{
    public static string EmpName = "Reshma";
    public static int EmpId = 1103;
    public static string companyName = "Gislen Software Pvt.Ltd";

    public static void EmployeeDetails()
    {
        System.Console.WriteLine("The Details of Employee...");

    }

} 
