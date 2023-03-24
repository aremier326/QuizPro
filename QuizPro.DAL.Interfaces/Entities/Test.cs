using QuizPro.DAL.Interfaces.Entities.Base;
using QuizPro.DAL.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QuizPro.DAL.Interfaces.Entities
{
    public class Test : BaseEntity
    {
        public String Question { get; set; }
        
        public String Answer1 { get; set; }
        
        public String Answer2 { get; set; }

        public String Answer3 { get; set; } 

        public String Answer4 { get; set; } 

        public String CorrectAnswer { get; set; }

        public TestTypeEnum TestType { get; set; }
    }
}
