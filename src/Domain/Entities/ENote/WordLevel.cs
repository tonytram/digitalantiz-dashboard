using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;
public class WordLevel
{
    public int WordId { get; set; }
    public required Word Word { get; set; }

    public int LevelId { get; set; }
    public required Level Level { get; set; }
}
