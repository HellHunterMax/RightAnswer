using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizzUI
{
    public partial class FormTheQuiz : Form
    {
        private List<QuestionModel> questionsList = new List<QuestionModel>();
        private int numberOfQuestionsToBeAsked = 0;
        private int numberOfQuestionsAsked = 0;
        public FormTheQuiz(int number)
        {
            numberOfQuestionsToBeAsked = number;
            GetQuestionsList();
            InitializeComponent();
            this.NextQuestion(null, null);
        }

        private void NextQuestion(object sender, MouseEventArgs e)
        {
            if(numberOfQuestionsAsked == numberOfQuestionsToBeAsked)
            {
                MessageBox.Show("Finished");
                Application.Exit();
            }
            this.CreateMyPanel(questionsList[numberOfQuestionsAsked]);
            numberOfQuestionsAsked++;
        }

        private void CreateMyPanel(QuestionModel theQuestion)
        {
            int numberOfAnswers = (theQuestion.WrongAnswers.Count + 1);

            Panel panel1 = new Panel
            {
                Size = new Size(1000, numberOfAnswers * 75),
                Location = new Point(12, 200)
            };
            for (int x = 0; x < numberOfAnswers; x++)
            {
                QuestionTile tile = new QuestionTile(x);
                tile.MouseDown += QuestionTile_MouseDown;
                panel1.Controls.Add(tile);
            }
            this.Controls.Add(panel1);

        }

        private void QuestionTile_MouseDown(object sender, MouseEventArgs e)
        {
            QuestionTile tile = (QuestionTile)sender;

            NextQuestion(null, null);

            //TODO when tile is pressed check if its the right answer >> add score >> next question.

        }
        private class QuestionTile : Button
        {
            internal Point GridPosition { get; }
            internal QuestionTile(int x)
            {
                this.Name = $"Question_{x}";
                this.Size = new Size(940, 75);
                this.Location = new Point(12, x * 75);
                this.TabIndex = 10 + x;
                this.GridPosition = new Point(12, x);
                this.Text = "hello";
            }

        }
        private void GetQuestionsList()
        {
            string cs = "Server=localhost; Port=5432; User Id=postgres; Password=12345678; Database=Quiz;";

            using(NpgsqlConnection con = new NpgsqlConnection(cs))
            {
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
                    Shuffle<QuestionModel>(questionsList);
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                    throw;
                }
            }

        }
        private void Shuffle<QuestionModel>(List<QuestionModel> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRoom.ThisTreadsRandom.Next(n + 1);
                QuestionModel value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
