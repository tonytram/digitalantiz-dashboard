using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class DailyGoal : OwnerPropertyEntity
{
    public DateTime GoalDate { get; set; }
    public int TargetWords { get; set; }
    public int AchievedWords { get; set; }
}
