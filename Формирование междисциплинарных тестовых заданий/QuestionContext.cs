using Microsoft.EntityFrameworkCore;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    class QuestionContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=products.db");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
