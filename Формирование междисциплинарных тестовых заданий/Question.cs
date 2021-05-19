using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
