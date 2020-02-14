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

        /// <summary>
        /// Next Question to be asked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextQuestion(object sender, MouseEventArgs e)
        {
            if(numberOfQuestionsAsked == numberOfQuestionsToBeAsked)
            {
                MessageBox.Show("Finished");
                Environment.Exit(1);
            }

            PlaceQuestionInForm(questionsList[numberOfQuestionsAsked]);
            this.CreateMyPanelOfAnswers(questionsList[numberOfQuestionsAsked]);
            numberOfQuestionsAsked++;
        }

        /// <summary>
        /// Pasts the Question and Question number to the form.
        /// </summary>
        /// <param name="theQuestion">The QuestionModel To be asked</param>
        private void PlaceQuestionInForm(QuestionModel theQuestion)
        {
            LabelQuestionNumbering.Text = "Question Number " + (numberOfQuestionsAsked+1).ToString() + "/" + numberOfQuestionsToBeAsked.ToString();
            LabelQuestion.Text = theQuestion.Question;
        }

        /// <summary>
        /// Creates a panel with all the possible answers for the asked question.
        /// </summary>
        /// <param name="theQuestion"></param>
        private void CreateMyPanelOfAnswers(QuestionModel theQuestion)
        {
            int numberOfAnswers = (theQuestion.WrongAnswers.Count + 1);

            List<string> questionList = new List<string>();

            questionList.Add(theQuestion.RightAnswer);

            foreach(string q in theQuestion.WrongAnswers)
            {
                questionList.Add(q);
            }
            MyExtentions.Shuffle<string>(questionList);

            Panel panel1 = new Panel
            {
                Size = new Size(1000, numberOfAnswers * 75),
                Location = new Point(12, 200)
            };
            for (int x = 0; x < numberOfAnswers; x++)
            {
                QuestionTile tile = new QuestionTile(x, questionList[x]);
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
            internal QuestionTile(int x, string q)
            {
                this.Name = $"Question_{x}";
                this.Size = new Size(940, 75);
                this.Location = new Point(12, x * 75);
                this.TabIndex = 10 + x;
                this.GridPosition = new Point(12, x);
                this.Text = q;
            }

        }

        /// <summary>
        /// Gets a list of possible Questions.
        /// </summary>
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
                    MyExtentions.Shuffle<QuestionModel>(questionsList);
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                    throw;
                }
            }

        }
        
    }
}
