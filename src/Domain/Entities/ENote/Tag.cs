using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class Tag : IEntity<int>
{
    public int Id { get; set; }

    public required string TagName { get; set; }

    public ICollection<Word>? Words { get; set; }

}
