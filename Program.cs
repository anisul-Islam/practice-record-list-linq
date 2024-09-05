class Program
{

    static void Main(string[] args)
    {

        
        var libraryManager = new LaibraryManagre();

      
        libraryManager.AddBook(new Book("1", "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", true));
        libraryManager.AddBook(new Book("2", "1984", "George Orwell", "Dystopian", true));
        libraryManager.AddBook(new Book("3", "To Kill a Mockingbird", "Harper Lee", "Classic", true));

   
        libraryManager.AddMember(new Member("1", "Alice Johnson", "alice@example.com"));
        libraryManager.AddMember(new Member("2", "Bob Smith", "bob@example.com"));
        libraryManager.DisplayBooks();
     
        libraryManager.BorrowBook("2", "1"); 
        libraryManager.BorrowBook("2", "2");

        libraryManager.ReturnBook("2", "1");
        libraryManager.SearchForBook("1");
        libraryManager.SearchForMember("2");



        



    }
}


