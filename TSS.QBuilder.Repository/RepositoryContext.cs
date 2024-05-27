using Microsoft.EntityFrameworkCore;
using TSS.QBuilder.Entities.Models;
using TSS.QBuilder.Repository.Configuration;

namespace TSS.QBuilder.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionSetConfiguration());
            modelBuilder.ApplyConfiguration(new ControlTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        }

        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ControlType> ControlTypes { get; set; }
    }
}
