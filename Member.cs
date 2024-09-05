public record Member
{
    public string Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }

    public Member(string id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}