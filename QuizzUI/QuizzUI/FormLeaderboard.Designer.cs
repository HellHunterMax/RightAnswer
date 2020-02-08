namespace QuizzUI
{
    partial class FormLeaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeaderboard));
            this.labelQuestionNumbering = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.LeaderboardDataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestionNumbering
            // 
            this.labelQuestionNumbering.AutoSize = true;
            this.labelQuestionNumbering.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumbering.ForeColor = System.Drawing.Color.Green;
            this.labelQuestionNumbering.Location = new System.Drawing.Point(80, 9);
            this.labelQuestionNumbering.Name = "labelQuestionNumbering";
            this.labelQuestionNumbering.Size = new System.Drawing.Size(244, 45);
            this.labelQuestionNumbering.TabIndex = 0;
            this.labelQuestionNumbering.Text = "Leaderboard";
            // 
            // backButton
            // 
            this.backButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButton.Location = new System.Drawing.Point(88, 447);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(301, 59);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // LeaderboardDataGrid
            // 
            this.LeaderboardDataGrid.AllowUserToAddRows = false;
            this.LeaderboardDataGrid.AllowUserToDeleteRows = false;
            this.LeaderboardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderboardDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlace,
            this.ColumnName,
            this.ColumnScore});
            this.LeaderboardDataGrid.Location = new System.Drawing.Point(12, 57);
            this.LeaderboardDataGrid.Name = "LeaderboardDataGrid";
            this.LeaderboardDataGrid.ReadOnly = true;
            this.LeaderboardDataGrid.RowHeadersVisible = false;
            this.LeaderboardDataGrid.RowHeadersWidth = 51;
            this.LeaderboardDataGrid.RowTemplate.Height = 24;
            this.LeaderboardDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LeaderboardDataGrid.Size = new System.Drawing.Size(424, 384);
            this.LeaderboardDataGrid.TabIndex = 9;
            // 
            // ColumnPlace
            // 
            this.ColumnPlace.HeaderText = "#";
            this.ColumnPlace.MinimumWidth = 6;
            this.ColumnPlace.Name = "ColumnPlace";
            this.ColumnPlace.ReadOnly = true;
            this.ColumnPlace.Width = 64;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 240;
            // 
            // ColumnScore
            // 
            this.ColumnScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnScore.HeaderText = "Score";
            this.ColumnScore.MinimumWidth = 6;
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.ReadOnly = true;
            this.ColumnScore.Width = 116;
            // 
            // FormLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 518);
            this.Controls.Add(this.LeaderboardDataGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.labelQuestionNumbering);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLeaderboard";
            this.Text = "Right Answer?";
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNumbering;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView LeaderboardDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
    }
}