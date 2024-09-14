using CleanArchitecture.Blazor.Domain.Common.Entities;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class Word : OwnerPropertyEntity
{
    public int WordId { get; set; }
    public required string WordText { get; set; }
    public required string Meaning { get; set; }
    public required string PartOfSpeech { get; set; }
    public required string Pronunciation { get; set; }  // For phonetic transcription (e.g., /ˈwɜːd/)

    // Navigation properties
    public required ICollection<ExampleSentence> ExampleSentences { get; set; }
    public required ICollection<WordTag> WordTags { get; set; }
    public required ICollection<WordLevel> WordLevels { get; set; }
    public ICollection<ArticleWord>? ArticleWords { get; set; }
    public ICollection<LearningProgress>? LearningProgresses { get; set; }
}
