using CleanArchitecture.Blazor.Domain.Entities.ENote;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Blazor.Infrastructure.Persistence.Configurations.ENote;
internal class WordConfiguration : IEntityTypeConfiguration<Word>
{
    public void Configure(EntityTypeBuilder<Word> builder)
    {
        builder.HasKey(w => w.Id);

        builder.Property(w => w.WordText)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(w => w.EMeaning)
            .HasColumnType("varchar(500)")
            .IsRequired();

        builder.Property(w => w.VMeaning)
            .HasColumnType("nvarchar(500)")
            .IsRequired();

        builder.Property(w => w.PartOfSpeech)
            .HasColumnType("varchar(10)")
            .IsRequired();

        builder.Property(w => w.Pronunciation)
            .HasColumnType("varchar(30)")
            .IsRequired();

        builder.HasMany(w => w.ExampleSentences)
            .WithOne(es => es.Word)
            .HasForeignKey(es => es.WordId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(w => w.WordTags)
            .WithOne(wt => wt.Word)
            .HasForeignKey(wt => wt.WordId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(w => w.WordLevels)
            .WithOne(wl => wl.Word)
            .HasForeignKey(wl => wl.WordId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(w => w.ArticleWords)
            .WithOne(aw => aw.Word)
            .HasForeignKey(aw => aw.WordId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(w => w.LearningProgresses)
            .WithOne(lp => lp.Word)
            .HasForeignKey(lp => lp.WordId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
