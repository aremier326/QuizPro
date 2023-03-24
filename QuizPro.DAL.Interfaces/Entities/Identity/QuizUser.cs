using Microsoft.AspNetCore.Identity;

namespace QuizPro.DAL.Interfaces.Entities.Identity;

// Add profile data for application users by adding properties to the QuizUser class
public class QuizUser : IdentityUser
{
    public IEnumerable<Quiz> Quizzes { get; set; } = new List<Quiz>();
}

