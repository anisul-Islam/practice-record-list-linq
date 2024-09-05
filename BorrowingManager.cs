
public record BorrowingRecord(Member BorrowingMember, books BorrowedBook, DateTime BorrowedDate);


public class BorrowingManager
{
    static List<BorrowingRecord> borrowingRecords = new List<BorrowingRecord>();

    public static void BorrowBook()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Borrow a Book");
        Console.WriteLine($"=================================================");

        Console.WriteLine("Please Enter the Member's Name:");
        string memberName = Console.ReadLine();
        var member = LibraryManager.GetMembers().FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));

        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        Console.WriteLine("Please Enter the Book Name:");
        string bookName = Console.ReadLine();
        var book = ManageBook.GetBooks().FirstOrDefault(b => b.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        // Check if the book is already borrowed
        if (borrowingRecords.Any(r => r.BorrowedBook.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("The book is already borrowed.");
            return;
        }

        // Record the borrowing
        borrowingRecords.Add(new BorrowingRecord(member, book, DateTime.Now));
        Console.WriteLine($"{memberName} has successfully borrowed '{bookName}'.");
    }

    public static void DisplayBorrowedBooks()
    {


        Console.WriteLine($"=================================================");
        Console.WriteLine($"Display Borrowed Books");
        Console.WriteLine($"=================================================");

        foreach (var record in borrowingRecords)
        {

            Console.WriteLine($"Member: {record.BorrowingMember.Name} borrowed '{record.BorrowedBook.NameOfBook}' on {record.BorrowedDate}");
        }

        if (!borrowingRecords.Any())
        {

            Console.WriteLine($"No book have bieng Borrwerd");

        }




    }



    public static void ReturnBook()
    {
        Console.WriteLine($"=================================================");
        Console.WriteLine($"Return a Book");
        Console.WriteLine($"=================================================");

        Console.WriteLine("Please Enter the Member's Name:");
        string memberName = Console.ReadLine();
        var member = LibraryManager.GetMembers().FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));

        if (member == null)
        {
            Console.WriteLine("Member not found.");
            return;
        }

        Console.WriteLine("Please Enter the Book Name:");
        string bookName = Console.ReadLine();
        var book = ManageBook.GetBooks().FirstOrDefault(b => b.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        // Find the borrowing record to remove
        var recordToRemove = borrowingRecords.FirstOrDefault(record =>
            record.BorrowingMember.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase) &&
            record.BorrowedBook.NameOfBook.Equals(bookName, StringComparison.OrdinalIgnoreCase));

        if (recordToRemove != null)
        {
            borrowingRecords.Remove(recordToRemove);
            Console.WriteLine($"{memberName} has successfully returned '{bookName}'.");
        }
        else
        {
            Console.WriteLine($"No borrowing record found for '{bookName}' borrowed by {memberName}.");
        }
    }

}
