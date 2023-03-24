using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizPro.DAL.Interfaces.Entities;
using QuizPro.DAL.Interfaces.Entities.Identity;

namespace QuizPro.DAL.Data;

public class QuizProContext : IdentityDbContext<QuizUser>
{
    public QuizProContext(DbContextOptions<QuizProContext> options)
        : base(options)
    {

    }

    DbSet<Test> Tests { get; set; }
    DbSet<Quiz> Quizzes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<QuizUser>()
            .ToTable("QuizUsers");

        builder.Entity<Quiz>()
            .ToTable("Quizzes");

        builder.Entity<Test>()
            .ToTable("Tests");

        builder.Entity<Quiz>()
            .HasMany(t => t.Tests);

        builder.Entity<QuizUser>()
            .HasMany(q => q.Quizzes);
    }
}
