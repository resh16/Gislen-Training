using System;

class Student
{
    public int studentId;
    public string studentName;

    public Student(int stu_id,string stu_name)
    {
        this.studentId = stu_id;
        this.studentName = stu_name;
    }

    public int getStu_Id()
    {
        return studentId;
    }

    public string getStu_Name()
    {
        return studentName;
    }
}
    class PublicExample
    {
        static void Main(string[] args)
        {
        Student s1 = new Student(101, "Rachel");
        Student s2 = new Student(102, "Ross");

        Console.WriteLine("Student ID :" + s1.studentId);
        Console.WriteLine("Student Name :" + s1.studentName);


        Console.WriteLine("Student ID :" + s2.getStu_Id());
        Console.WriteLine("Student Name :" + s2.getStu_Name());




        Console.ReadKey();
       
        }
        
    }

