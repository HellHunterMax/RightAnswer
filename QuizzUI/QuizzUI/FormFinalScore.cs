using System;
using System.Windows.Forms;

namespace QuizzUI
{
    public partial class FormFinalScore : Form
    {
        /// <summary>
        /// This form is to be showed after the quiz is finished so the player can input his name and save the score to the LeaderBoard.
        /// </summary>
        /// <param name="finalScore">the final score of the player.</param>
        public FormFinalScore(int finalScore)
        {
            InitializeComponent();
            EditScoreText(finalScore);
        }

        private void EditScoreText(int finalScore)
        {
            LabelTheScore.Text = "Your Final Score is : " + finalScore.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length < 3 || textBoxName.Text.Length > 15)
            {
                MessageBox.Show("Name must be more than 2 and less than 16.");
            }
            else
            {
                MessageBox.Show("Your Score is saved " + textBoxName.Text, "Score saved.");

                this.Close();
                //Environment.Exit(1);
            }


        }
    }
}
