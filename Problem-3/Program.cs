using System.Data.Common;
using System;
using System.Diagnostics;
public record Book(string Title, string Author, string Genre, Guid Id = default, bool IsAvailable = true){
    public Guid Id { get; init; } = Guid.NewGuid();
}
public record Member(string Name, string Email, Guid Id = default){
    public Guid Id { get; init; } = Guid.NewGuid();
}
public record BorrowRecord(Member member, Book borrowed, DateTime date, Guid Id = default)
{
    public Guid Id { get; init; } = Guid.NewGuid();
}

class LibraryManager
{
    List<Book> books = new List<Book>();
    List<Member> members = new List<Member>();
    List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }
    public void DeleteBook(string bookName)
    {
        if (books.Any(book => book.Title == bookName))
        {
            books.Remove(books.FirstOrDefault(book => book.Title == bookName));
            Console.WriteLine($"Book removed successfully.");
        }
        else
        {
            Console.WriteLine($"There is no book with this name");
        }
    }
    public Book SearchForBookByTitle(string title)
    {
        Console.WriteLine($"\nSearching for books with '{title}':");
        var book = books.FirstOrDefault(book => book.Title == title);
        return book;
    }
    public Book SearchForBookByAuthor(string author)
    {
        var foundbook = books.FirstOrDefault(book => book.Author == author);
        return foundbook;
    }
    public IEnumerable<Book> SearchForBookByGenre(string genre)
    {
        var foundBook = from book in books
                        where book.Genre == genre
                        select book;
        return foundBook;
    }
    public void DisplayAllBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Book {{ Id = {book.Id}, Title = {book.Title}, Author = {book.Author}, Genre = {book.Genre}, IsAvailable = {book.IsAvailable} }}");
        }
    }

    public void AddMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member '{member.Name}' added to the library.");
    }
    public void DeleteMember(string memberName)
    {
        if (books.Any(book => book.Title == memberName))
        {
            members.Remove(members.FirstOrDefault(member => member.Name == memberName));
            Console.WriteLine($"Member removed successfully.");
        }
        else
        {
            Console.WriteLine($"There is no member with this name");
        }
    }
    public void DisplayAllMembers()
    {
        Console.WriteLine("\nLibrary Members:");
        foreach (var member in members)
        {
            Console.WriteLine($"Member {{ Id = {member.Id}, Name = {member.Name}, Email = {member.Email} }}");
        }
    }
    public Member SearchForMember(string name)
    {
        var member = members.FirstOrDefault(member => member.Name == name);
        return member;
    }

    public void AddBorrowBook(BorrowRecord borrowBook)
    {
        Console.WriteLine($"\nBorrowing a book:");
        if (borrowRecords.Any(record => record.borrowed.Title == borrowBook.borrowed.Title))
        {
            Console.WriteLine($"Sorry, this book is unavailable");
        }else{
            borrowRecords.Add(borrowBook);
            Console.WriteLine($"Book '{borrowBook.borrowed.Title}' borrowed by '{borrowBook.member.Name}'.");
            
        }
    }
    public void ReturnBorrowedBook(string bookTitle)
    {
        Console.WriteLine($"\nReturning a book:");
        if (borrowRecords.Any(record => record.borrowed.Title == bookTitle))
        {
            var record = borrowRecords.FirstOrDefault(record => record.borrowed.Title == bookTitle);
            borrowRecords.Remove(record);
            Console.WriteLine($"Book '{record.borrowed.Title}' returned by '{record.member.Name}'.");
        }
        else
        {
            Console.WriteLine($"There is no book with this title");
        }
    }
    public void DisplayAllBorrowedBooks()
    {
        if(borrowRecords.Any()){
            foreach (var record in borrowRecords)
            {
                Console.WriteLine($"{record.borrowed.Title} borrowed by {record.member.Name} on{{{record.date.ToShortDateString()}}}");
            }
        }else{
            Console.WriteLine($"No books are currently borrowed.");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        LibraryManager library = new LibraryManager();
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction");
        Book book2 = new Book("1984", "George Orwell", "Dystopian");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", "Classic");
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        
        Member member1 = new Member("Alice Johnson", "alice@example.com");
        Member member2 = new Member("Bob Smith", "bob@example.com");
        library.AddMember(member1);
        library.AddMember(member2);

        library.DisplayAllBooks();
        library.DisplayAllMembers();

        var foundBook = library.SearchForBookByTitle("1984");
        Console.WriteLine($"Book {{ Id = {foundBook.Id}, Title = {foundBook.Title}, Author = {foundBook.Author}, Genre = {foundBook.Genre}, IsAvailable = {foundBook.IsAvailable} }}");
        BorrowRecord record1 = new BorrowRecord(member1, book2, DateTime.Now);
        library.AddBorrowBook(record1);
        Console.WriteLine("\nDisplaying borrowed books:");
        library.DisplayAllBorrowedBooks();

        library.ReturnBorrowedBook("1984");

        Console.WriteLine($"\nDisplaying borrowed books after return:");
        library.DisplayAllBorrowedBooks();
    }
}