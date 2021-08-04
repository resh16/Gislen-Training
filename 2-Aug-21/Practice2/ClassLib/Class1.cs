public class Student
{
    public string StudentName;
    public int StudentId;
    public string Student_class;

    public static string SchoolName = "Gislen School";

    public Student(string StudentName, int StudentId, string Student_class)
    {
        this.StudentName = StudentName;
        this.StudentId = StudentId;
        this.Student_class = Student_class;
    }
    public static void DisplayStudentDetails(Student s)
    {
        System.Console.WriteLine("Students Details...");
        System.Console.WriteLine(s.StudentName);
        System.Console.WriteLine(s.StudentId);
        System.Console.WriteLine(s.Student_class);
        System.Console.WriteLine(SchoolName);



    }
}
