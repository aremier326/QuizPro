using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuizPro.DAL.Data
{
    internal class QuizProDbContextFactory : IDesignTimeDbContextFactory<QuizProContext>
    {
        public QuizProContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QuizProContext>();

            var connectionString = @"Data Source=.\SQLEXPRESS;Integrated Security=true;TrustServerCertificate=True;Initial Catalog=QuizPro;Multiple Active Result Sets=True";


            optionsBuilder.UseSqlServer(connectionString);
            return new QuizProContext(optionsBuilder.Options);
        }
    }
}
