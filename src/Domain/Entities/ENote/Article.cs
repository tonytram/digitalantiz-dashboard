using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class Article : BaseAuditableEntity
{
    public required string Title { get; set; }
    public required string Content { get; set; }

    // Navigation properties
    public ICollection<Audio>? Audios { get; set; }
    public ICollection<ArticleWord>? ArticleWords { get; set; }
}
