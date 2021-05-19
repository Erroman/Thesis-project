using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Answer>
        Answers
        { get; private set; } =
        new ObservableCollection<Answer>();
    }
}
