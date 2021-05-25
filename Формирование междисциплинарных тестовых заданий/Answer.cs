using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Формирование_междисциплинарных_тестовых_заданий
{
    public class Answer
    {
   
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
               
        public bool IsRight { get; set; }

        public virtual Question Question { get; set; }

    }
}
 