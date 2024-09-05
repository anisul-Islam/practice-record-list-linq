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
/*
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
*/

// Third library problem
public record Book(int Id, string Title, string Gener, string Author, bool IsAvailable = true);
public record Member(int Id, string Name, string Email);
public record BorrowRecord(string Title, string Member, DateTime Date);

class LibraryManager
{
    List<Book> booksList = new List<Book>();
    List<Member> membersList = new List<Member>();
    List<BorrowRecord> borrowBooksList = new List<BorrowRecord>();
    public void AddBook(Book book)
    {
        booksList.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");

    }
    public void RemoveBook(string title)
    {
        var foundBook = booksList.FirstOrDefault(book => book.Title == title);
        if (foundBook != null)
        {
            booksList.Remove(foundBook);
            Console.WriteLine($"Book '{title}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"There is no book called '{title}' in the library");

        }
    }
    public void SearchBook(string userInput)
    {
        var foundBook = booksList.FirstOrDefault(book => book.Author == userInput
         || book.Title == userInput || book.Gener == userInput);
        if (foundBook != null)
        {
            Console.WriteLine($"Searching for books with '{foundBook.Title}':");

            Console.WriteLine($"{foundBook}");
        }
        else
        {
            Console.WriteLine($"There is no book called '{userInput}' in the library");

        }

    }
    public void DisplayAllBooks()
    {
        if (booksList.Count() != 0)
        {
            Console.WriteLine($"Library Books: ");

            foreach (var book in booksList)
            {
                Console.WriteLine($"{book}");
            }
        }
        else
        {
            Console.WriteLine($"Library books is empty!");
        }
    }

    public void AddMember(Member member)
    {
        membersList.Add(member);
        Console.WriteLine($"Member '{member.Name}' added to the library.");


    }
    public void RemoveMember(string name)
    {
        var foundMember = membersList.FirstOrDefault(member => member.Name == name);
        if (foundMember != null)
        {
            membersList.Remove(foundMember);
            Console.WriteLine($"Member '{name}' removed from the library.");

        }
        else
        {
            Console.WriteLine($"There is no member called '{name}.'");

        }
    }
    public void SearchMember(string name)
    {
        var foundMember = membersList.FirstOrDefault(member => member.Name == name);
        if (foundMember != null)
        {
            Console.WriteLine($"Found: {foundMember}");
        }
        else
        {
            Console.WriteLine($"There is no member called '{name}.");

        }
    }
    public void DisplayAllMembers()
    {
        if (membersList.Count() != 0)
        {
            Console.WriteLine($"Library Members: ");

            foreach (var member in membersList)
            {
                Console.WriteLine($"{member}");
            }
        }
        else
        {
            Console.WriteLine($"Members List is empty!");
        }
    }
    public void BorrowBook(string bookTitle, string memberName)
    {
        var foundBook = booksList.FirstOrDefault(book => book.Title == bookTitle);
        var foundMember = membersList.FirstOrDefault(member => member.Name == memberName);

        if (foundBook != null && foundMember != null)
        {
            if (foundBook.IsAvailable)
            {
                booksList[booksList.FindIndex(book => book.Title == bookTitle)] = foundBook with { IsAvailable = false };
                borrowBooksList.Add(new BorrowRecord(bookTitle, memberName, DateTime.Now));
                Console.WriteLine($"Borrowing a book: ");

                Console.WriteLine($"'{bookTitle}' borrowed by {memberName} on {DateTime.Now}.");

            }
            else
            {
                Console.WriteLine($"The book is already borrowed.");

            }
        }
        else
        {
            Console.WriteLine($"There is no book called '{bookTitle}' or member called '{memberName}'.");

        }

    }
    public void ReturnBook(string bookTitle, string memberName)
    {
        var foundBook = booksList.FirstOrDefault(book => book.Title == bookTitle);
        var foundMember = membersList.FirstOrDefault(member => member.Name == memberName);

        if (foundBook != null && foundMember != null)
        {
            if (!foundBook.IsAvailable)
            {
                booksList[booksList.FindIndex(book => book.Title == bookTitle)] = foundBook with { IsAvailable = true };
                var borrowedBook = borrowBooksList.FirstOrDefault(br => br.Title == bookTitle && br.Member == memberName);
                if (borrowedBook != null)
                {
                    borrowBooksList.Remove(borrowedBook);
                    Console.WriteLine($"Returning a book: ");

                    Console.WriteLine($"Book '{bookTitle}' returned by '{memberName}'");
                }

            }
            else
            {
                Console.WriteLine($"This book is not in the borrow list to return it.");

            }

        }
        else
        {
            Console.WriteLine($"There is no book called '{bookTitle}' or member called '{memberName}'.");

        }
    }
    public void DisplayAllBorrowedBooks()
    {
        if (borrowBooksList.Count() != 0)
        {
            foreach (var borrowBook in borrowBooksList)
            {
                Console.WriteLine($"Displaying borrowed books: ");

                Console.WriteLine($"{borrowBook}");
            }
        }
        else
        {
            Console.WriteLine($"No books are currently borrowed.");
        }
    }
}
class Run
{
    public static void Main(string[] args)
    {
        LibraryManager libraryManager = new LibraryManager();
        libraryManager.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction"));
        libraryManager.AddBook(new Book(2, "1984", "George Orwell", "Dystopian"));
        libraryManager.AddBook(new Book(3, "To Kill a Mockingbird", "Harper Lee", "Classic"));
        libraryManager.AddMember(new Member(1, "Alice Johnson", "alice@example.com"));
        libraryManager.AddMember(new Member(2, "Bob Smith", "bob@example.com"));
        libraryManager.DisplayAllBooks();
        libraryManager.DisplayAllMembers();
        libraryManager.SearchBook("1984");
        libraryManager.BorrowBook("1984", "Alice Johnson");
        libraryManager.DisplayAllBorrowedBooks();
        libraryManager.ReturnBook("1984", "Alice Johnson");
        libraryManager.DisplayAllBorrowedBooks();

    }
}
