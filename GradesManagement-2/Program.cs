public record Student(string Name, double Grade, string Subject);

class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student studentX)// Adds a new student to the list.
    {
        students.Add(studentX);
        Console.WriteLine($"Student {studentX.Name} added successfully.");

    }


    public void RemoveStudent(string name) // remove student by name
    {

        Student? studentToRemove = students.FirstOrDefault(studentName => studentName.Name == name);

        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"Student {studentToRemove.Name} Deleted successfully.");
        }
        else
        {
            Console.WriteLine($"Student {name} not found!");
        }
    }


    public void DisplayAllStudent()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"\t-Student {student.Name}: has {student.Grade} in {student.Subject}");
        }
    }



}


public class Program
{
    
    static void Main(string[] args)
    {

        Student student1 = new Student("Aseel",89.9,"ComputerSince");
        Student student2 = new Student("Sarah",85,"ComputerSince");
        Student student3 = new Student("Ibrahim",70,"ComputerSince");
        Student student4 = new Student("Amal",91,"Math");


        //Adding Student
        StudentManager studentManager = new StudentManager();
        studentManager.AddStudent(student1);
        studentManager.AddStudent(student2);
        studentManager.AddStudent(student3);
        studentManager.AddStudent(student4);

        //Displaying Student
        Console.WriteLine($"\nDisplaying all Student:");
        studentManager.DisplayAllStudent();
        Console.WriteLine($"\n");

        //Removing Student
        studentManager.RemoveStudent("Amal");

        //Displaying Student
        Console.WriteLine($"\nDisplaying all Student after removal:");
        studentManager.DisplayAllStudent();
        Console.WriteLine($"\n");





    }

}