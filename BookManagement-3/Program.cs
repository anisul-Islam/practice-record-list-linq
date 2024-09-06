using System;

public record Book(string Title, string Author, string Genre, int Id)
{
    private static int counter = 100;

    public Book(string Title, string Author, string Genre) 
        : this(Title, Author, Genre, counter++) //assigns an autoIncrement ID start from 100
    {
    }
}



public record Member(string Name, string PhoneNumber, string Email)
{

    //assigns a read only ID for members
    private string id = Guid.NewGuid().ToString();
    public string Id { get { return id; } }
};


public record BorrowRecord(int BookId, string MemberId, int Id)
{
    private static int counter = 100;

    
    public BorrowRecord(int bookId, string memberId) 
        : this(bookId, memberId, counter++) //assigns a sequential Id
    {
    }


    private DateTime dateOfBorrow = DateTime.Now;

    public DateTime DateOfBorrow { get { return dateOfBorrow; } }

};







public class LibraryManager
{


    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();
    private List<BorrowRecord> borrowRecord = new List<BorrowRecord>();




    //books Methods
    public void AddBook(Book newBook)
    {

        books.Add(newBook);
        Console.WriteLine($"Book '{newBook.Title}' added to the library.");

    }


    public void RemoveBook(Book bookToDelete)
    {

        if (books.Any(book => book == bookToDelete))
        {
            books.Remove(bookToDelete);
            Console.WriteLine($"book '{bookToDelete.Title}' deleted from the library");
        }
        else
        {
            Console.WriteLine($"book '{bookToDelete.Title}' not in the list");
        }
    }


    public Book SearchForBook(string bookTitle)
    {
        Book? book = books.FirstOrDefault(book => book.Title == bookTitle);

        return book ?? throw new Exception($"Book Not Found");
    }


    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"\t-{book}");
        }
    }




    //Members Methods
    public void AddMember(Member newMember)
    {

        members.Add(newMember);
        Console.WriteLine($"Member {newMember.Name} Add successfully.");

    }


    public void RemoveMember(Member memberToDelete)
    {

        if (members.Any(member => member == memberToDelete))
        {

            members.Remove(memberToDelete);
            Console.WriteLine($"Member '{memberToDelete.Name}' Deleted successfully.");

        }
        else
        {
            Console.WriteLine($"Member '{memberToDelete.Name}' not it the list");
        }
    }


    public Member SearchForMember(string memberName)
    {
        Member? member = members.FirstOrDefault(member => member.Name == memberName);
        return member ?? throw new Exception("Member not found");

    }


    public void DisplayMembers()
    {
        foreach (var member in members)
        {
            Console.WriteLine($"\t-{member}");
        }
    }




    //Methods to handle borrowing and returning books
    public void BorrowingBook(int bookID, string memberID)
    {

        if (books.Any(book => book.Id == bookID) && members.Any(member => member.Id == memberID))
        {
            borrowRecord.Add(new BorrowRecord(bookID, memberID));
            
            var getBook = books.FirstOrDefault(book => book.Id == bookID);
            var getMember = members.FirstOrDefault(member => member.Id == memberID);

            Console.WriteLine($"Book '{getBook.Title}' borrowed by '{getMember.Name}' \n");

        }

    }

    public BorrowRecord? FindARecord(int bookId, string memberId)
    {

        if (borrowRecord.Any(x => x.BookId == bookId && x.MemberId == memberId))
        {
            BorrowRecord? GetTheBooked = borrowRecord.FirstOrDefault(x => x.BookId == bookId && x.MemberId == memberId);
            return GetTheBooked;
        }



        return null;
    }


    public void ReturningBook(int bookId, string memberId)
    {
        BorrowRecord? GetTheBooked = FindARecord(bookId, memberId);
        if (GetTheBooked != null)
        {


            var getBook = books.FirstOrDefault(book => book.Id == bookId);
            var getMember = members.FirstOrDefault(member => member.Id == memberId);


            borrowRecord.Remove(GetTheBooked);
            // //change the book to available
            Console.WriteLine($"\nBook'{getBook.Title}' returned by '{getMember.Name}'.\n");
        }
        else
        {
            throw new Exception("booked not found");
        }




    }

    public void DisplayBorrowRecord()
    {

        if (borrowRecord.Any())
        {
            foreach (var record in borrowRecord)
            {

                

                var getBook = books.FirstOrDefault(book => book.Id == record.BookId);
                var getMember = members.FirstOrDefault(member => member.Id == record.MemberId);

                Console.WriteLine($"\t{record.Id}- Book '{getBook.Title}' borrowed by '{getMember.Name}' on {record.DateOfBorrow.ToShortDateString()} ");

            }
        }
        else
        {
            throw new Exception("No books are currently borrowed.\n");
        }

    }
   
   
   
    /* , method for bool Is book Available */






}








public class Program
{
    public static void Main(string[] args)
    {

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction");
        Book book2 = new Book("1984", "George Orwell", "Dystopian");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", "Classic");


        Member member1 = new Member("Alice Johnson", "06650000000", "alice@example.com");
        Member member2 = new Member("Bob Smith", "0577080000", "bob@example.com");

        LibraryManager library = new LibraryManager();


        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddMember(member1);
        library.AddMember(member2);
        Console.WriteLine($"\n Library Books:\n");
        library.DisplayBooks();
        Console.WriteLine($"\n Library Members:\n");
        library.DisplayMembers();


        // try for searching the book by name
        try
        {
            Console.WriteLine($"\n Searching for books'1984'");
            Console.WriteLine($"\t-{library.SearchForBook("1984")}\n");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"\n{ex.Message}");
        }



        //try for borrowing the book
        try
        {

            library.BorrowingBook(book1.Id, member1.Id);
            library.BorrowingBook(book1.Id, member2.Id);
            library.BorrowingBook(book3.Id, member1.Id);
            Console.WriteLine($"List all borrow record:");
            library.DisplayBorrowRecord();


        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"\n{ex.Message}");
        }


        //try to returning the book
        try
        {
            Console.WriteLine($" ");
            library.ReturningBook(book1.Id,member1.Id);
            Console.WriteLine($"List all borrow record:");
            library.DisplayBorrowRecord();
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"\n{ex.Message}");
        }



    }
}