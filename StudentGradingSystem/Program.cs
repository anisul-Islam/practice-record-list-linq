
using StudentRecord;
using StudentManagerClass;
class Program{
    public static void Main(string[] args){ 

        Student student1 = new Student("Ahmed",90,"Math");
        Student student2 = new Student("ali",85,"Math");
        Console.WriteLine($"{student1.Name}");

        StudentManager studentManager1 = new StudentManager(new List<Student>());

        studentManager1.AddStudent(student1);
        studentManager1.AddStudent(student2);

        studentManager1.DisplayAllStudents();

    }
}