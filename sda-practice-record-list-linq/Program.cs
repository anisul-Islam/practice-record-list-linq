// First problem contact
/*
public record Contact(string Name, string phoneNumber, string Email);
class ContactManager
{
    List<Contact> contactInfo = new List<Contact>();
    public void AddContact(Contact contact)
    {
        contactInfo.Add(contact);
        Console.WriteLine($"Contact \"{contact.Name}\" added successfully.");

    }
    public void RemoveContact(string name)
    {
        var contactBasedOnName = contactInfo.FirstOrDefault(contact => contact.Name == name);
        if (contactBasedOnName != null)
        {
            contactInfo.Remove(contactBasedOnName);
            Console.WriteLine($"Contact \"{name}\" removed successfully.");
        }
        else
        {
            Console.WriteLine($"There is no contact called \"{name}\"");

        }

    }

    public Contact? FindContact(string name)
    {
        var contactFound = contactInfo.FirstOrDefault(contact => contact.Name == name);
        return contactFound;

    }
    public void DisplayContacts()
    {
        if (contactInfo.Count() != 0)
        {
            foreach (var contact in contactInfo)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.phoneNumber}, Email: {contact.Email}");
            }
        }

    }
}

class Run
{
    public static void Main(string[] args)
    {
        ContactManager manager = new ContactManager();
        while (true)
        {
            Console.WriteLine($"A: Add, R: Remove, D: Display, F: Found, Q: Quit");
            string userInput = Console.ReadLine();
            if (userInput.Trim().ToUpper() == "A")
            {
                Console.WriteLine($"Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter your phone: ");
                string phone = Console.ReadLine();
                Console.WriteLine($"Enter your email: ");
                string email = Console.ReadLine();
                Contact contact = new Contact(name, phone, email);
                manager.AddContact(contact);
            }
            else if (userInput.Trim().ToUpper() == "R")
            {
                Console.WriteLine($"Enter the name you want to remove: ");
                string name = Console.ReadLine();
                manager.RemoveContact(name);
            }
            else if (userInput.Trim().ToUpper() == "D")
            {
                Console.WriteLine($"Displaying all contacts: ");
                manager.DisplayContacts();
            }
            else if (userInput.Trim().ToUpper() == "F")
            {
                Console.WriteLine($"Enter the name you want to find: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Finding a contact named {name}:");
                Console.WriteLine($"Found: {manager.FindContact(name)}");
            }
            else if (userInput.Trim().ToUpper() == "Q")
            {
                break;
            }
        }
    }
}
*/

// Seconed problem student grade
public record Student(string Name, double Grade, string Subject);

class StudentManager
{
    List<Student> studentsList = new List<Student>();

    public void AddStudent(Student student)
    {
        studentsList.Add(student);
        Console.WriteLine($"\"{student.Name}\" was added successfully.");

    }
    public void RemoveStudent(string name)
    {
        var foundStudent = studentsList.FirstOrDefault(student => student.Name == name);
        if (foundStudent != null)
        {
            studentsList.Remove(foundStudent);
            Console.WriteLine($"\"{name}\" was removed successfully.");
        }
        else
        {
            Console.WriteLine($"there is no student called \"{name}\"");

        }
    }

    public void DisPlayAllStudents()
    {
        if (studentsList.Count() == 0)
        {
            Console.WriteLine($"The student kist is empty!");

        }
        else
        {
            foreach (var student in studentsList)
            {
                Console.WriteLine($"{student.Name}, {student.Grade}, {student.Subject}");

            }
        }
    }
}
class Run
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Ghadah", 4.81, "CS");
        Student student2 = new Student("Samar", 4.75, "Sport");
        Student student3 = new Student("Najwa", 4.50, "CHEM");

        StudentManager manager = new StudentManager();
        manager.AddStudent(student1);
        manager.AddStudent(student2);
        manager.AddStudent(student3);
        manager.DisPlayAllStudents();
        manager.RemoveStudent("Ghadah");
        manager.DisPlayAllStudents();
    }
}