using CleanArchitecture.Blazor.Domain.Entities.ENote;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Blazor.Infrastructure.Persistence.Configurations.ENote
{
    internal class ExampleSentenceConfiguration : IEntityTypeConfiguration<ExampleSentence>
    {
        public void Configure(EntityTypeBuilder<ExampleSentence> builder)
        {
            builder.HasKey(es => es.Id);
            
            builder.Property(es => es.SentenceText)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            builder.Property(es => es.Meaning)
                .HasColumnType("nvarchar(1000)")
                .IsRequired();

            builder.HasOne(es => es.Word)
                .WithMany(w => w.ExampleSentences)
                .HasForeignKey(es => es.WordId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(es => es.Audios)
                .WithOne(a => a.ExampleSentence)
                .HasForeignKey(a => a.SentenceId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
