using System.ComponentModel;

namespace CleanArchitecture.Blazor.Domain.Entities.ENote.Enums
{
    public enum PartOfSpeechEnum
    {
        [Description("n.")] Noun,
        [Description("v.")] Verb,
        [Description("adj.")] Adjective,
        [Description("adv.")] Adverb,
        [Description("prop.")] Proposition,
    }
}
