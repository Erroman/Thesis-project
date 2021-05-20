using Microsoft.EntityFrameworkCore;
namespace Формирование_междисциплинарных_тестовых_заданий
{
    class QuestionContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseSqlite(
                "Data Source=tests.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
