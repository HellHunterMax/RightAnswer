using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves A new Question to the Database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Returns the Question Including Unique indentifier.</returns>
        public QuestionModel CreateQuestion(QuestionModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
