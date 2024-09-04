public record Contact (string Name, string PhoneNumber, string Email);
public record Student (string Name, double Grade , string Subject);
class ContactManager{

    public static List <Contact> contacts = new List <Contact>();

    public static void AddContact(Contact contact){
        contacts.Add(contact);
        Console.WriteLine($"Contact \"{contact.Name}\" added successfully.");
    }
    public static void RemoveContact(Contact contact){

        if(contacts.Any())
        {
            contacts.Remove(contact);
            Console.WriteLine($"Contact \"{contact.Name}\" removed successfully.");
            DisplayContacts();
            
        }
        else
        {
            Console.WriteLine("The Contact not exies!");
        }
        
    }
    public static void FindContact(string name){

        Console.WriteLine($"Finding a contact named {name}");
        var foundName = contacts.FirstOrDefault(contact => contact.Name == name);

       if (foundName != null)
       {
            Console.WriteLine($"Found: {foundName}");
       }
       else
       {
            Console.WriteLine("Not Found!");
       }
       
    }
    public static void DisplayContacts(){
        Console.WriteLine("\nDisplaying all contacts:");

        foreach (Contact contact in contacts){
            Console.WriteLine($"Name: {contact.Name}, Phone: {contact.PhoneNumber}, Email: {contact.Email}");
        }
       
    }
    
}

class StudentManager
{
    public static List<Student> students = new List<Student>();
    public static void AddStudent(Student student)
    {
        students.Add(student);
    }

    public static void RemoveStudent(string name)
    {
        var removeStudent = students.FirstOrDefault(student => student.Name == name);
        if(removeStudent != null)
        {
            students.Remove(removeStudent);
        }
    }

    public static void DisplayAllStudents()
    {
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Grade : {student.Grade}, Subject : {student.Subject}");
        }
    }

}



class App{
    public static void Main(string[] args){
        


        // Contact c1 = new Contact("Alice Johnson","123-456-7890","alice@example.com");
        // Contact c2= new Contact("Bob Smith","098-765-4321","bob@example.com");
        // Contact c3 = new Contact("Charlie Brown","555-555-5555","charlie@example.com");

        // ContactManager.AddContact(c1);
        // ContactManager.AddContact(c2);
        // ContactManager.AddContact(c3);
        // ContactManager.DisplayContacts();
        // ContactManager.FindContact("Bob Smith");
        // ContactManager.FindContact("Charlie Smith");
        // ContactManager.RemoveContact(c1);


        // Student s1 = new Student("Abeer",98,"math");
        // Student s2 = new Student("Sara",98,"physics");

        // StudentManager.AddStudent(s1);
        // StudentManager.AddStudent(s2);
        // StudentManager.DisplayAllStudents();
        
        
        

    }
}