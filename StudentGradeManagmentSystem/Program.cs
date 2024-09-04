using System;
using System.Collections.Generic;
record Student(string Name, double Grade, string Subject);

class StudentManager{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student){
        students.Add(student);
        Console.WriteLine($"Student \"{student.Name}\" added successfully.");
    }

    public void RemoveStudent(string name){
        Student studentToRemove = students.Find(s => s.Name == name);
        if (studentToRemove != null){
            students.Remove(studentToRemove);
            Console.WriteLine($"Student \"{name}\" removed successfully.");
        }else{
            Console.WriteLine($"Student \"{name}\" not found.");
        }
    }

    public void DisplayAllStudents(){
        Console.WriteLine("Displaying all students:");
        foreach (var student in students){
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Subject: {student.Subject}");
        }
    }
}

class StudentManagerMain{
    static void Main(string[] args){
        StudentManager manager = new StudentManager();
        
        Student alice = new Student("Alice Johnson", 95.5, "Mathematics");
        Student bob = new Student("Bob Smith", 88.0, "English");
        Student charlie = new Student("Charlie Brown", 92.3, "Science");
        
        manager.AddStudent(alice);
        manager.AddStudent(bob);
        manager.AddStudent(charlie);

        Console.WriteLine();
        manager.DisplayAllStudents();

        Console.WriteLine("\nRemoving 'Alice Johnson':");
        manager.RemoveStudent("Alice Johnson");

        Console.WriteLine("\nDisplaying students after removal:");
        manager.DisplayAllStudents();
    }
}
