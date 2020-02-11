using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public interface IDataConnection
    {
        QuestionModel CreateQuestion(QuestionModel model);
    }
}
