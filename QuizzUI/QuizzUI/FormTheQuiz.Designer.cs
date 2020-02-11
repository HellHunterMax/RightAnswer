namespace QuizzUI
{
    partial class FormTheQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheQuiz));
            this.LabelQuestionNumbering = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelQuestionNumbering
            // 
            this.LabelQuestionNumbering.AutoSize = true;
            this.LabelQuestionNumbering.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestionNumbering.ForeColor = System.Drawing.Color.Green;
            this.LabelQuestionNumbering.Location = new System.Drawing.Point(284, 26);
            this.LabelQuestionNumbering.Name = "LabelQuestionNumbering";
            this.LabelQuestionNumbering.Size = new System.Drawing.Size(415, 45);
            this.LabelQuestionNumbering.TabIndex = 0;
            this.LabelQuestionNumbering.Text = "Question Number 1/10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 128);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormTheQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelQuestionNumbering);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTheQuiz";
            this.Text = "Right Answer?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private QuestionsGrid questionsGrid;
        private System.Windows.Forms.Label LabelQuestionNumbering;
        private System.Windows.Forms.Label label1;
    }
}