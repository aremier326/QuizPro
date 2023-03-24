using QuizPro.DAL.Interfaces.Entities.Base;
using QuizPro.DAL.Interfaces.Enums;

namespace QuizPro.DAL.Interfaces.Entities
{
    public class Quiz : BaseEntity
    {
        public String Description { get; set; } = "Just some test";

        public IEnumerable<ActiveTest> Tests { get; set; } = new List<ActiveTest>();

        public decimal Result { get; set; }

        public TestTypeEnum QuizType { get; set; }
    }
}
