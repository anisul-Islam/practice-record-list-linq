public record Book
{
    public string Id { get; init; }
    public string Title { get; init; }
    public string Author { get; init; }
    public string Genre { get; init; }
    public bool IsAvailable { get; set; } // This can be set to true/false when borrowed

    public Book(string id, string title, string author, string genre, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
    }
}