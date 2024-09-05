public record BorrowRecord
{
    public Book BorrowedBook { get; init; }
    public Member BorrowMember { get; init; }
    public DateTime BorrowDate { get; init; }

    public BorrowRecord(Book borrowedBook, Member borrowMember, DateTime borrowDate)
    {
        BorrowedBook = borrowedBook;
        BorrowMember = borrowMember;
        BorrowDate = borrowDate;
    }
}