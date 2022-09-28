namespace Wiki.Dtos;

public record Document
{
    public Guid Id { get; init; }
    public string Name { get; }
}