namespace Wiki.Dtos;

public class DocumentDto
{
    public Guid Id { get; set; }
    public string DocumentName { get; }
    
    public DocumentDto(Guid id, string documentName)
    {
        Id = id;
        DocumentName = documentName;
    }
}