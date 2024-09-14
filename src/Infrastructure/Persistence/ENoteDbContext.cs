using CleanArchitecture.Blazor.Domain.Entities.ENote;

namespace CleanArchitecture.Blazor.Infrastructure.Persistence;
internal class ENoteDbContext(DbContextOptions<ApplicationDbContext> options) : ApplicationDbContext(options)
{
    public DbSet<Word> Words { get; set; }
    public DbSet<ExampleSentence> ExampleSentences { get; set; }
    public DbSet<LearningProgress> LearningProgresses { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<WordTag> WordTags { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<WordLevel> WordLevels { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<ArticleWord> ArticleWords { get; set; }
    public DbSet<DailyGoal> DailyGoals { get; set; }
}
