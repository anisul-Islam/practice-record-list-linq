using System.Runtime.Serialization;
using System;

namespace LibraryRecords{

    public record Book(int ID, string Title , string Auther , string Genre ,  bool Available = true);
    public record Member(int ID , string Name , string Email);
    public record BorrowRecord(int BookID, int MemberID , DateTime BorrowTime , DateTime ReturnTime);

}