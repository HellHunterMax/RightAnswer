using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizzUI
{
    public partial class FormTheQuiz : Form
    {
        private List<QuestionModel> questionsList= new List<QuestionModel>();
        public FormTheQuiz()
        {
            GetQuestionsList();
            InitializeComponent();
        }

        private void GetQuestionsList()
        {
            string cs = "Server=localhost; Port=5432; User Id=postgres; Password=12345678; Database=Quiz;";

            NpgsqlConnection con = new NpgsqlConnection(cs);
            try
            {
                con.Open();

                string sql = "SELECT * FROM Public.\"Questions\"";
                var cmd = new NpgsqlCommand(sql, con);
                using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        List<string> wrongAnswersList = new List<string>();
                        string[] wrongAnswersString = rdr[3] as string[];

                        foreach (string wronganswer in wrongAnswersString)
                        {
                            wrongAnswersList.Add(wronganswer);
                        }

                        QuestionModel a = new QuestionModel()
                        {
                            Id = rdr.GetInt32(0),
                            Question = rdr.GetString(1),
                            RightAnswer = rdr.GetString(2),
                            WrongAnswers = wrongAnswersList
                        };
                        questionsList.Add(a);
                    }
                }

                con.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }

        }
    }
}
