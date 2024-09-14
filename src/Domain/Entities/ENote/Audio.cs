using CleanArchitecture.Blazor.Domain.Common.Entities;
using CleanArchitecture.Blazor.Domain.Entities.ENote.Enums;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;
public class Audio : BaseAuditableEntity
{
    public int AudioId { get; set; }
    public required string FileUrl { get; set; }
    public required AudioTypeEnum AudioType { get; set; }

    public int? WordId { get; set; }
    public Word? Word { get; set; }

    public int? ArticleId { get; set; }
    public Article? Article { get; set; }

    public int? SentenceId { get; set; }
    public ExampleSentence? ExampleSentence { get; set; }
}
