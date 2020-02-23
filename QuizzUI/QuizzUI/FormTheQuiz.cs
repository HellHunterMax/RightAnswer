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

            this.NextQuestion();
        }

        /// <summary>
        /// Next Question to be asked.
        /// </summary>
        private void NextQuestion()
        {
            if (numberOfQuestionsAsked == numberOfQuestionsToBeAsked)
            {
                MessageBox.Show("Finished");
                Environment.Exit(1);
            }


            this.CreateMyPanelOfAnswers(questionsList[numberOfQuestionsAsked]);
            numberOfQuestionsAsked++;
        }


        /// <summary>
        /// Creates a panel with all the possible answers for the asked question.
        /// </summary>
        /// <param name="theQuestion"></param>
        private void CreateMyPanelOfAnswers(QuestionModel theQuestion)
        {
            List<string> questionList = new List<string>();

            // Adding possible Answers to the List.

            questionList.Add(theQuestion.RightAnswer);
            foreach (string q in theQuestion.WrongAnswers)
            {
                questionList.Add(q);
            }
            MyExtentions.Shuffle<string>(questionList); // shuffle the list.
            int numberOfAnswers = questionList.Count;

            Label LabelQuestionNumbering = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Green,
                Location = new Point(284, 26),
                Name = "LabelQuestionNumbering",
                Size = new Size(415, 45),
                TabIndex = 0,
                Text = "Question Number " + (numberOfQuestionsAsked + 1).ToString() + "/" + numberOfQuestionsToBeAsked.ToString()
            };
            Label LabelQuestion = new Label
            {
                AutoSize = true,
                ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
                Location = new Point(12, 71),
                MaximumSize = new Size(1000, 0),
                Name = "LabelQuestion",
                Size = new Size(991, 128),
                TabIndex = 1,
                Text = theQuestion.Question
            };

            //Creating a panel with answers.
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
            this.Controls.Add(LabelQuestionNumbering);
            this.Controls.Add(LabelQuestion);
            this.Controls.Add(panel1);

            void QuestionTile_MouseDown(object sender, MouseEventArgs e)
            {
                QuestionTile tile = (QuestionTile)sender;

                if (tile.Text == theQuestion.RightAnswer)
                {
                    MessageBox.Show("Correct Answer!", "Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong Answer!", "Wrong!");
                }
                this.Controls.Remove(LabelQuestion);
                this.Controls.Remove(LabelQuestionNumbering);
                this.Controls.Remove(panel1);
                NextQuestion();
                //TODO when tile is pressed check if its the right answer >> add score >> next question.

            }
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

            using (NpgsqlConnection con = new NpgsqlConnection(cs))
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
