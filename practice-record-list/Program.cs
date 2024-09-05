public record Contact (string Name, string PhoneNumber, string Email);
public record Student (string Name, double Grade , string Subject);
public record Book (int Id, string Title , string Author, string Genre , bool IsAvailable );
public record Member  (int Id, string Name, string Email);
public record BorrowRecord(string BorrowBook,string BorrowBy, DateTime date);
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

class LibraryManager
{
    public static List<Book> books = new List<Book>();
    public static List<Member> members = new List<Member>();
    public static List<BorrowRecord> borrowRecord = new List<BorrowRecord>();

    public static void AddBook(Book newbook)
    {
        books.Add(newbook);
        Console.WriteLine($"Book \'{newbook.Title}\' added to the library.");
    }

    public static void RemoveBook (Book book)
    {
        if(books.Contains(book))
        {
            books.Remove(book);
        }
        else
        {
            Console.WriteLine("The book that your trying to remove is not found!");
        }
        
    }
    public static void DisplayAllBooks ()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
    public static void SearchForBook(string bookTitle)
    {
        Console.WriteLine($"\nSearching for books with \'{bookTitle}\':");
       var bookFound = books.FirstOrDefault(book => book.Title == bookTitle);
       if (bookFound != null)
       {
            Console.WriteLine(bookFound);
       }
       else
       {
            Console.WriteLine("Book not found!");
       }
        
    }

    public static void AddMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member \'{member.Name}\' added to the library.");
    }

    public static void RemoveMember(Member member)
    {
        members.Remove(member);
    }
    public static void DisplayAllMembers ()
    {
        Console.WriteLine("\nLibrary Members:");
        foreach(Member member in members)
        {
            Console.WriteLine(member);
        }
    }

    public static void SearchForMember (string memberName)
    {
        
        var foundMember = members.Where(member => member.Name == memberName);

       
        Console.WriteLine($"\nSearching for members called '{string.Join(", ", foundMember.Select(member => member.Name))}' ");

        if(foundMember != null)
        {
            Console.WriteLine($"Member found");
        }
        else
        {
            Console.WriteLine($"Member not found!");
        }


    }

   
    public static void BorrowBook (Book newBorrowBook, Member borrowBy, BorrowRecord newBorrowRecord)
    {
      //var borrowBookName = books.FirstOrDefault(book => book.Title == newBorrowBook.Title);
      var memberName = members.FirstOrDefault(member => member.Name == borrowBy.Name);

      if(books.Any() && memberName != null)
      {
        Console.WriteLine($"\nBorrowing a book:\nBook '{newBorrowBook.Title}' borrowed by {memberName.Name}");
        borrowRecord.Add(newBorrowRecord);
      }
      else
      {
        Console.WriteLine("The book dose not found!");
      }
    }

    public static void DisplyAllBorrowedBook ()
    {
        Console.WriteLine("\nDisplaying borrowed books:");
        foreach (BorrowRecord borrow in borrowRecord)
        {
            Console.WriteLine($"{borrow.BorrowBook} borrowed by {borrow.BorrowBy} on [{borrow.date}]");
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

        Book book1 = new Book(1, "The Great Gatsby","F. Scott Fitzgerald","Fiction",true); 
        Book book2 = new Book(2, " 1984"," George Orwell","Dystopian",true);
        Book book3 = new Book(3, " To Kill a Mockingbird","Harper Lee","Classic",true);

        LibraryManager.AddBook(book1);
        LibraryManager.AddBook(book2);
        LibraryManager.AddBook(book3);

        Member member1 = new Member(1,"Alice Johnson","alice@example.com");
        Member member2 = new Member(2,"Bob Smith","bob@example.com");

        LibraryManager.AddMember(member1);
        LibraryManager.AddMember(member2);
        LibraryManager.DisplayAllBooks();
        LibraryManager.DisplayAllMembers();
        LibraryManager.SearchForBook("The Great Gatsby");

        DateTime currentDate = DateTime.Now;
        BorrowRecord record = new BorrowRecord("The Great Gatsby","Alice Johnson",currentDate);
        LibraryManager.BorrowBook(book1,member1,record);
        
        LibraryManager.DisplyAllBorrowedBook();
       

    }
}