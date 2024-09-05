using System;
using System.Collections.Generic;
using System.Linq;

public record Book(int Id, string Title, string Author, string Genre, bool IsAvailable = true);
public record Member(int Id, string Name, string Email);
public record BorrowRecord(int BookId, int MemberId, DateTime BorrowDate);

public class LibraryManager{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();
    private List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

    public void AddBook(Book book){
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void RemoveBook(int bookId){
        var book = books.SingleOrDefault(b => b.Id == bookId);
        if (book != null){
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' removed from the library.");
        }
    }

    public void DisplayAllBooks(){
        Console.WriteLine("\nLibrary Books:");
        books.ForEach(book => Console.WriteLine(book));
    }

    public void SearchBooks(string searchTerm){
        var searchResults = books.Where(book => book.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                book.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                book.Genre.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"\nSearching for books with '{searchTerm}':");
        foreach (var book in searchResults) Console.WriteLine(book);
    }

    public void AddMember(Member member){
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' added to the library.");
    }

    public void RemoveMember(int memberId){
        var member = members.SingleOrDefault(m => m.Id == memberId);
        if (member != null){
            members.Remove(member);
            Console.WriteLine($"Member '{member.Name}' removed from the library.");
        }
    }

    public void DisplayAllMembers(){
        Console.WriteLine("\nLibrary Members:");
        members.ForEach(member => Console.WriteLine(member));
    }

    public void SearchMembers(string searchTerm){
        var searchResults = members.Where(member => member.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"\nSearching for members with '{searchTerm}':");
            foreach (var member in searchResults)   Console.WriteLine(member);
    }

    public void BorrowBook(int memberId, int bookId){
        var member = members.SingleOrDefault(m => m.Id == memberId);
        var book = books.SingleOrDefault(b => b.Id == bookId && b.IsAvailable);

        if (member != null && book != null){
            books[books.FindIndex(b => b.Id == bookId)] = book with { IsAvailable = false };
            borrowRecords.Add(new BorrowRecord(bookId, memberId, DateTime.Now));
            Console.WriteLine($"Book '{book.Title}' borrowed by '{member.Name}'.");
        }
    }

    public void ReturnBook(int memberId, int bookId){
        var member = members.SingleOrDefault(m => m.Id == memberId);
        var book = books.SingleOrDefault(b => b.Id == bookId && !b.IsAvailable);
        var borrowRecord = borrowRecords.SingleOrDefault(br => br.BookId == bookId && br.MemberId == memberId);

        if (member != null && book != null && borrowRecord != null){
            books[books.FindIndex(b => b.Id == bookId)] = book with { IsAvailable = true };
            borrowRecords.Remove(borrowRecord);
            Console.WriteLine($"Book '{book.Title}' returned by '{member.Name}'.");
        }
    }

    public void DisplayBorrowedBooks(){
        var borrowedBooks = from br in borrowRecords
                            join b in books on br.BookId equals b.Id
                            join m in members on br.MemberId equals m.Id
                            select new {Book = b, Member = m, br.BorrowDate};

        Console.WriteLine("\nDisplaying borrowed books:");
        if (!borrowedBooks.Any()){
            Console.WriteLine("No books are currently borrowed.");
        }else{
            foreach (var record in borrowedBooks)  
                Console.WriteLine($"{record.Book.Title} borrowed by {record.Member.Name} on {record.BorrowDate.ToShortDateString()}");
        }
    }
}

class Program{

    static void Main(string[] args){
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.AddBook(new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction"));
        libraryManager.AddBook(new Book(2, "1984", "George Orwell", "Dystopian"));
        libraryManager.AddBook(new Book(3, "To Kill a Mockingbird", "Harper Lee", "Classic"));

        libraryManager.AddMember(new Member(1, "Alice Johnson", "alice@example.com"));
        libraryManager.AddMember(new Member(2, "Bob Smith", "bob@example.com"));

        libraryManager.DisplayAllBooks();
        libraryManager.DisplayAllMembers();

        libraryManager.SearchBooks("1984");

        libraryManager.BorrowBook(1, 2);

        libraryManager.DisplayBorrowedBooks();

        libraryManager.ReturnBook(1, 2);

        libraryManager.DisplayBorrowedBooks();
    }
}