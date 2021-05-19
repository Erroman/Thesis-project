using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Question>
            Questions
        { get; private set; } =
            new ObservableCollection<Question>();
    }
}
