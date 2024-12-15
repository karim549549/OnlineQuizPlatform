namespace OnlineQuizPlatform.Forms
{
    partial class AdminDashBoard
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
            SideBar = new Panel();
            QuestionButton = new Button();
            UserButton = new Button();
            UserPanel = new Panel();
            UserDataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            QuestionPanel = new Panel();
            QuestionDataGrid = new DataGridView();
            Question = new DataGridViewTextBoxColumn();
            Score1 = new DataGridViewTextBoxColumn();
            SideBar.SuspendLayout();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).BeginInit();
            QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionDataGrid).BeginInit();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = SystemColors.Highlight;
            SideBar.Controls.Add(QuestionButton);
            SideBar.Controls.Add(UserButton);
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(145, 449);
            SideBar.TabIndex = 0;
            // 
            // QuestionButton
            // 
            QuestionButton.BackColor = SystemColors.HotTrack;
            QuestionButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionButton.ForeColor = SystemColors.ControlLightLight;
            QuestionButton.Location = new Point(3, 205);
            QuestionButton.Name = "QuestionButton";
            QuestionButton.Size = new Size(139, 67);
            QuestionButton.TabIndex = 2;
            QuestionButton.Text = "Questions";
            QuestionButton.UseVisualStyleBackColor = false;
            QuestionButton.Click += QuestionButton_Click;
            // 
            // UserButton
            // 
            UserButton.BackColor = SystemColors.HotTrack;
            UserButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserButton.ForeColor = SystemColors.ButtonHighlight;
            UserButton.Location = new Point(3, 119);
            UserButton.Name = "UserButton";
            UserButton.Size = new Size(139, 67);
            UserButton.TabIndex = 1;
            UserButton.Text = "Users";
            UserButton.UseVisualStyleBackColor = false;
            UserButton.Click += UserButton_Click;
            // 
            // UserPanel
            // 
            UserPanel.BackColor = SystemColors.ActiveCaptionText;
            UserPanel.Controls.Add(UserDataGrid);
            UserPanel.Location = new Point(151, 0);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(645, 449);
            UserPanel.TabIndex = 0;
            // 
            // UserDataGrid
            // 
            UserDataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            UserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Score });
            UserDataGrid.Location = new Point(58, 55);
            UserDataGrid.Name = "UserDataGrid";
            UserDataGrid.RowHeadersWidth = 62;
            UserDataGrid.Size = new Size(517, 267);
            UserDataGrid.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.MinimumWidth = 8;
            Score.Name = "Score";
            Score.Width = 150;
            // 
            // QuestionPanel
            // 
            QuestionPanel.BackColor = SystemColors.ActiveCaptionText;
            QuestionPanel.Controls.Add(QuestionDataGrid);
            QuestionPanel.Location = new Point(154, 1);
            QuestionPanel.Name = "QuestionPanel";
            QuestionPanel.Size = new Size(642, 448);
            QuestionPanel.TabIndex = 1;
            // 
            // QuestionDataGrid
            // 
            QuestionDataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            QuestionDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionDataGrid.Columns.AddRange(new DataGridViewColumn[] { Question, Score1 });
            QuestionDataGrid.Location = new Point(125, 7);
            QuestionDataGrid.Name = "QuestionDataGrid";
            QuestionDataGrid.RowHeadersWidth = 62;
            QuestionDataGrid.Size = new Size(365, 434);
            QuestionDataGrid.TabIndex = 0;
            // 
            // Question
            // 
            Question.HeaderText = "Question";
            Question.MinimumWidth = 8;
            Question.Name = "Question";
            Question.Width = 150;
            // 
            // Score1
            // 
            Score1.HeaderText = "Score1";
            Score1.MinimumWidth = 8;
            Score1.Name = "Score1";
            Score1.Width = 150;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SideBar);
            Controls.Add(UserPanel);
            Controls.Add(QuestionPanel);
            Text = "AdminDashBoardForm";
            SideBar.ResumeLayout(false);
            UserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).EndInit();
            QuestionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QuestionDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBar;
        private Panel UserPanel;
        private Panel QuestionPanel;
        private DataGridView UserDataGrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Score;
        private DataGridView QuestionDataGrid;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Score1;
        private Button QuestionButton;
        private Button UserButton;
    }
}