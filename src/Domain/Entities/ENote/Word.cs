﻿using CleanArchitecture.Blazor.Domain.Common.Entities;
using CleanArchitecture.Blazor.Domain.Entities.ENote.Enums;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote;

public class Word : OwnerPropertyEntity
{
    public required string WordText { get; set; }
    public required string VMeaning { get; set; }
    public required string EMeaning { get; set; }
    public required PartOfSpeechEnum PartOfSpeech { get; set; }
    public required string Pronunciation { get; set; }  // For phonetic transcription (e.g., /ˈwɜːd/)

    public required ICollection<ExampleSentence> ExampleSentences { get; set; }
    public required ICollection<Tag> Tags { get; set; }
    public required ICollection<WordLevel> WordLevels { get; set; }
    public ICollection<ArticleWord>? ArticleWords { get; set; }
    public ICollection<LearningProgress>? LearningProgresses { get; set; }
}
