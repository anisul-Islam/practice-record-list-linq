public record books(string NameOfBook, int PageOfNumber, string AuthorName);


public class ManageBook
{
    static List<books> bookItems = new List<books>(); // Make this static


    // Add a public method to access memberItems
    public static List<books> GetBooks()
    {
        return bookItems;
    }

    public static void Addbook()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Add Book in the library ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Add The Data Book:");

        Console.WriteLine($"Please Enter the Name: ");
        string BookName = Console.ReadLine();

        Console.WriteLine($"Please Enter PageNumber: ");
        int PageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Please Enter the Author Name: ");
        string AuthorName = Console.ReadLine();

        var dataBook = new books(BookName, PageNumber, AuthorName);
        bookItems.Add(dataBook);
    }

    public static void DisplayBook()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Display Books");
        Console.WriteLine($"=================================================");

        foreach (var book in bookItems)
        {
            Console.WriteLine($"Book Name: {book.NameOfBook} // Page Numbers: {book.PageOfNumber} Author Name: {book.AuthorName}");
        }
    }

    public static void RemoveBook(string bookName)
    {
        var removeBook = bookItems.FirstOrDefault(book => book.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase));

        if (removeBook != null)
        {
            bookItems.Remove(removeBook);
            Console.WriteLine($"{bookName} has been removed.");
        }
        else
        {
            Console.WriteLine($"The book '{bookName}' that you searched for does not exist.");
        }
    }

    public static void RemovingBook()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Remove Book ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Enter the Name of the book:");
        string bookName = Console.ReadLine();
        RemoveBook(bookName);
    }

    public static void SearchBookName(string bookName)
    {
        var bookInfo = bookItems.FirstOrDefault(book => book.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase));

        if (bookInfo != null)
        {
            Console.WriteLine($"{bookName} exists.");
            Console.WriteLine($"Book Information");
            Console.WriteLine($"Book Name: {bookInfo.NameOfBook}");
            Console.WriteLine($"Page Number: {bookInfo.PageOfNumber}");
            Console.WriteLine($"Author Name: {bookInfo.AuthorName}");
        }
        else
        {
            Console.WriteLine($"The book '{bookName}' you are looking for does not exist!");
        }
    }

    public static bool CheckBook(string nameOfBook)
    {
        // Check if any book in the collection matches the given name
        bool CheckBook = bookItems.Any(bookItem => bookItem.NameOfBook == nameOfBook);

        return CheckBook;
    }

    public static void SearchingBookName()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Search Book ");
        Console.WriteLine($"=================================================");

        Console.WriteLine($"Please Enter the Name of the book:");
        string bookName = Console.ReadLine();

        SearchBookName(bookName);
    }

    // Borrowing Books


}
