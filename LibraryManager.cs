



using System.Linq.Expressions;
using System.Collections.Generic;

class LaibraryManagre
{
    // Manage collections of books, members, and borrow records using lists.
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();
    private List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

    public Book? Books { get; set; }
    public Member? Members { get; set; }
    public BorrowRecord? BorrowRecords { get; set; }


    public Book FindBook(string id)
    {
        return
       books.FirstOrDefault(c => c.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }
    public Member FindMember(string id)
    {
        return
        members.FirstOrDefault(c => c.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }
    public void AddBook(Book book)
    {
        string title = book.Title;

        if (FindBook(title) == null)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title} is added.");

        }
        else
            Console.WriteLine($"The book {book.Title} is alredy exsist");
    }

    public void AddMember(Member member)
    {

        if (FindMember(member.Email) == null)
        {
            members.Add(member);
            Console.WriteLine($"The member {member.Name} is added");
        }
        else
            Console.WriteLine($"The Member is alredy exsist");
    }

    public void RemoveBook(string title)
    {
        if (books == null)
            Console.WriteLine($"No books found");
        else
        {

            if (FindBook(title) == null)
                Console.WriteLine($"Book not found");
            else
            {
                books.Remove(FindBook(title));
                Console.WriteLine($"book is removed");
            }
        }
    }

    public void RemoveMember(string email)
    {
        if (members == null)
            Console.WriteLine($"No members found");
        else
        {

            if (FindMember(email) == null)
                Console.WriteLine($"No member found");
            else
            {
                members.Remove(FindMember(email));
                Console.WriteLine($"Member with email {email} is removed");
            }
        }
    }

    public void SearchForBook(string id)
    {
        Console.WriteLine($"Book found...");
        Console.WriteLine($"Id = {FindBook(id).Id} Title = {FindBook(id).Title} Author = {FindBook(id).Author} genre = {FindBook(id).Genre} isAvailable = {FindBook(id).IsAvailable}");
    }
    public void SearchForMember(string id)
    {
        Console.WriteLine($"Member found...");
        Console.WriteLine($"Id = {FindMember(id).Id} Name = {FindMember(id).Name} Email = {FindMember(id).Email}");

    }


    public void DisplayBooks()
    {
        Console.WriteLine($"The books in the library:");
        foreach (var book in books)
        {

            Console.WriteLine($"Id = {book.Id} Title = {book.Title} Author = {book.Author} genre = {book.Genre} isAvailable = {book.IsAvailable}");
        }
    }

    public void DisplayMembers()
    {
        foreach (var member in members)
        {
            Console.WriteLine($"Id = {member.Name} Name = {member.Name} Email = {member.Email}");
        }
    }


    public void BorrowBook(string bookId, string memberId)
    {
        // join to find available books and valid members
        var borrowableRecord = (from b in books
                                join m in members on memberId equals m.Id
                                where b.Id == bookId && b.IsAvailable
                                select new { Book = b, Member = m }).FirstOrDefault();

        if (borrowableRecord != null)
        {
            // update the book as not available
            borrowableRecord.Book.IsAvailable = false;

            // Create a new borrow record
            var borrowRecord = new BorrowRecord(borrowableRecord.Book, borrowableRecord.Member, DateTime.Now);
            borrowRecords.Add(borrowRecord);

            Console.WriteLine($"Book '{borrowableRecord.Book.Title}' borrowed by '{borrowableRecord.Member.Name}'.");
        }
        else
        {
            Console.WriteLine("Book is not available or member not found.");
        }
    }

    public void ReturnBook(String bookId, string memberId)
    {

        var returnedBook = borrowRecords.FirstOrDefault
        (r => r.BorrowedBook.Id == bookId && r.BorrowMember.Id == memberId);
        if (returnedBook != null)
        {
            returnedBook.BorrowedBook.IsAvailable = true;
            borrowRecords.Remove(returnedBook);
            Console.WriteLine($"Book {returnedBook.BorrowedBook.Title} returned by {returnedBook.BorrowMember.Name}.");

        }
        else
            Console.WriteLine($"No matching borrow record found");




    }





}
