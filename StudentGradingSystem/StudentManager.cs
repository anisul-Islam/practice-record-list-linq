using StudentRecord;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagerClass
{
class StudentManager{
    private List<Student> Students{get; set;}

    public StudentManager(List<Student> students){
        Students = students;
    }

    public void AddStudent(Student student){
        Students.Add(student);
    }

    public void RemoveStudent(Student student){
        Students.Remove(student);
    }

    public void DisplayAllStudents(){
        
        foreach(Student student in Students){
            
            Console.WriteLine($"student Name: {student.Name} - grade: {student.Grade} - Subject: {student.Subject} ");

            Console.WriteLine($"--------------------------------------------------------------------");
            
            
        }
    }


}

}

namespace MyNamespace
{
    public class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine($"Text");
            
        }
    }
}