using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class LearningProgress : IEntity<int>
{
    public int Id { get; set; }
    public int WordId { get; set; }
    public int UserId { get; set; } // Optional for multi-user tracking
    public int TimesReviewed { get; set; }
    public DateTime? LastReviewedAt { get; set; }
    public float SuccessRate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Navigation properties
    public Word Word { get; set; }
}
