using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class Level : IEntity<int>
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public ICollection<WordLevel>? WordLevels { get; set; }
}
