namespace CleanArchitecture.Blazor.Domain.Entities.ENote;
public class WordTag
{
    public int WordId { get; set; }
    public required Word Word { get; set; }

    public int TagId { get; set; }
    public required Tag Tag { get; set; }
}
