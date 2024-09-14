using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class ArticleWord : BaseAuditableEntity
{
    public int ArticleId { get; set; }
    public required Article Article { get; set; }

    public int WordId { get; set; }
    public required Word Word { get; set; }
}
