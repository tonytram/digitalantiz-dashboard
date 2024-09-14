using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class ExampleSentence : BaseAuditableEntity
{
    public int WordId { get; set; }
    public required string SentenceText { get; set; }
    public required string Meaning { get; set; }

    public required Word Word { get; set; }
    public ICollection<Audio>? Audios { get; set; }
}
