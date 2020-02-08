namespace QuizzUI
{
    partial class FormFinalScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinalScore));
            this.LabelTheScore = new System.Windows.Forms.Label();
            this.LabelEnterName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelTheScore
            // 
            this.LabelTheScore.AutoSize = true;
            this.LabelTheScore.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTheScore.ForeColor = System.Drawing.Color.Green;
            this.LabelTheScore.Location = new System.Drawing.Point(162, 9);
            this.LabelTheScore.Name = "LabelTheScore";
            this.LabelTheScore.Size = new System.Drawing.Size(444, 45);
            this.LabelTheScore.TabIndex = 0;
            this.LabelTheScore.Text = "Your Final Score is : 100";
            // 
            // LabelEnterName
            // 
            this.LabelEnterName.AutoSize = true;
            this.LabelEnterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelEnterName.Location = new System.Drawing.Point(107, 54);
            this.LabelEnterName.Name = "LabelEnterName";
            this.LabelEnterName.Size = new System.Drawing.Size(558, 32);
            this.LabelEnterName.TabIndex = 1;
            this.LabelEnterName.Text = "Please enter your name for the leaderboard.";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 89);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(540, 39);
            this.textBoxName.TabIndex = 2;
            // 
            // FormFinalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 167);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.LabelEnterName);
            this.Controls.Add(this.LabelTheScore);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormFinalScore";
            this.Text = "Right Answer?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTheScore;
        private System.Windows.Forms.Label LabelEnterName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}