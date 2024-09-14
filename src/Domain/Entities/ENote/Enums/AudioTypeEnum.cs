using System.ComponentModel;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote.Enums;

public enum AudioTypeEnum
{
    [Description("Word")] Word,
    [Description("Article")] Article,
    [Description("Sentence")] Sentence,
}
