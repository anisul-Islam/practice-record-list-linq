public class Program
{
    public enum enMainList { ManageBook = 1, ManageMember = 2, BorrowingSystem = 3, Exit = 4 };

    public enum enManageBookList { AddBook = 1, RemoveBook = 2, DisplayBook = 3, SearchBook = 4, BackToMain = 5 };

    public enum enManageMemberList { AddMember = 1, RemoveMember = 2, DisplayAllMember = 3, SearchMember = 4, BackToMain = 5 };

    public enum enBorrowingSystemList { BorrowBook = 1, ReturnBook = 2, DisplayBorrowedBooks = 3, BackToMain = 4 };

    public static void ShowBorrowingSystemMenu()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("Borrowing System Menu");
        Console.WriteLine("=======================================");
        Console.WriteLine("[1] Borrow Book");
        Console.WriteLine("[2] Return Book");
        Console.WriteLine("[3] Display Borrowed Books");
        Console.WriteLine("[4] Go Back To Main Menu");
        Console.WriteLine("=======================================");
        PerformBorrowingSystemOption((enBorrowingSystemList)ReadNumber());
    }

    public static void PerformBorrowingSystemOption(enBorrowingSystemList borrowingOption)
    {
        switch (borrowingOption)
        {
            case enBorrowingSystemList.BorrowBook:
                Console.Clear();
                BorrowingManager.BorrowBook();
                GoBackToBorrowingSystemMenu();
                break;

            case enBorrowingSystemList.ReturnBook:
                Console.Clear();
                BorrowingManager.ReturnBook();
                GoBackToBorrowingSystemMenu();
                break;

            case enBorrowingSystemList.DisplayBorrowedBooks:
                Console.Clear();
                BorrowingManager.DisplayBorrowedBooks();
                GoBackToBorrowingSystemMenu();
                break;

            case enBorrowingSystemList.BackToMain:
                Console.Clear();
                GoBackToMainMenu();
                break;
        }
    }

    public static void GoBackToBorrowingSystemMenu()
    {
        Console.WriteLine("Press any key to Go back");
        Console.ReadKey();
        ShowBorrowingSystemMenu();
    }

    public static short ReadNumber()
    {
        Console.WriteLine("Choose from the Menu:");
        short readNumber = Convert.ToInt16(Console.ReadLine());
        return readNumber;
    }

    public static void GoBackToMainMenu()
    {
        Console.WriteLine("Press any key to Go back");
        Console.ReadKey();
        ShowMainMenu();
    }

    public static void GoBackToManageBookMenue()
    {
        Console.WriteLine("Press any key to Go back");
        Console.ReadKey();
        ShowManageBookMenu();
    }

    public static void GoBackToManageMemberMenue()
    {
        Console.WriteLine("Press any key to Go back");
        Console.ReadKey();
        ShowManageMemberMenue();
    }

    public static void PerformMenuOption(enMainList mainListOption)
    {
        switch (mainListOption)
        {
            case enMainList.ManageBook:
                Console.Clear();
                ShowManageBookMenu();
                break;

            case enMainList.ManageMember:
                Console.Clear();
                ShowManageMemberMenue();
                break;

            case enMainList.BorrowingSystem:
                Console.Clear();
                ShowBorrowingSystemMenu();
                break;
        }
    }

    public static void PerformManageBookOption(enManageBookList manageBookOption)
    {
        switch (manageBookOption)
        {
            case enManageBookList.AddBook:
                Console.Clear();
                ManageBook.Addbook();
                GoBackToManageBookMenue();
                break;

            case enManageBookList.RemoveBook:
                Console.Clear();
                ManageBook.RemovingBook();
                GoBackToManageBookMenue();
                break;

            case enManageBookList.DisplayBook:
                Console.Clear();
                ManageBook.DisplayBook();
                GoBackToManageBookMenue();
                break;

            case enManageBookList.SearchBook:
                Console.Clear();
                ManageBook.SearchingBookName();
                GoBackToManageBookMenue();
                break;

            case enManageBookList.BackToMain:
                Console.Clear();
                GoBackToMainMenu();
                break;
        }
    }

    public static void PerformManageMemberOption(enManageMemberList enManageMember)
    {
        switch (enManageMember)
        {
            case enManageMemberList.AddMember:
                Console.Clear();
                LibraryManager.AddMember();
                GoBackToManageMemberMenue();
                break;

            case enManageMemberList.RemoveMember:
                Console.Clear();
                LibraryManager.RemovingMember();
                GoBackToManageMemberMenue();
                break;

            case enManageMemberList.DisplayAllMember:
                Console.Clear();
                LibraryManager.DisplayMembers();
                GoBackToManageMemberMenue();
                break;

            case enManageMemberList.SearchMember:
                Console.Clear();
                LibraryManager.SearchingMemberName();
                GoBackToManageMemberMenue();
                break;

            case enManageMemberList.BackToMain:
                Console.Clear();
                GoBackToMainMenu();
                break;
        }
    }

    public static void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("Main Menu");
        Console.WriteLine("=======================================");
        Console.WriteLine("[1] Manage Book");
        Console.WriteLine("[2] Manage Member");
        Console.WriteLine("[3] Borrowing System");
        Console.WriteLine("[4] Exit");
        PerformMenuOption((enMainList)ReadNumber());
    }

    public static void ShowManageBookMenu()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("Manage Book Menu");
        Console.WriteLine("=======================================");
        Console.WriteLine("[1] Add Book");
        Console.WriteLine("[2] Re move Book");
        Console.WriteLine("[3] Display Books");
        Console.WriteLine("[4] Search Book");
        Console.WriteLine("[5] Go Back To Main Menu");
        PerformManageBookOption((enManageBookList)ReadNumber());
    }

    public static void ShowManageMemberMenue()
    {
        Console.Clear();
        Console.WriteLine("=======================================");
        Console.WriteLine("Manage Member Menu");
        Console.WriteLine("=======================================");
        Console.WriteLine("[1] Add Member");
        Console.WriteLine("[2] Remove Member");
        Console.WriteLine("[3] Display Members");
        Console.WriteLine("[4] Search Member");
        Console.WriteLine("[5] Go Back To Main Menu");
        PerformManageMemberOption((enManageMemberList)ReadNumber());
    }

    public static void Main(string[] args)
    {
        ShowMainMenu();
    }
}
