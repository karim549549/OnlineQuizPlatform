namespace OnlineQuizPlatform.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Title = new Label();
            LeaderBoardTable = new TableLayoutPanel();
            label1 = new Label();
            QuizPanel = new Panel();
            progressBar1 = new ProgressBar();
            Submit = new Button();
            Next = new Button();
            Back = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Question = new Label();
            TakeQuizButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LeaderBoardTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            QuizPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(Title);
            panel1.Controls.Add(LeaderBoardTable);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 450);
            panel1.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.ButtonHighlight;
            Title.Location = new Point(12, 21);
            Title.Name = "Title";
            Title.Size = new Size(121, 32);
            Title.TabIndex = 3;
            Title.Text = "Welcome ";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LeaderBoardTable
            // 
            LeaderBoardTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            LeaderBoardTable.ColumnCount = 2;
            LeaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4972687F));
            LeaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.50273F));
            LeaderBoardTable.ForeColor = SystemColors.ButtonHighlight;
            LeaderBoardTable.Location = new Point(0, 143);
            LeaderBoardTable.Name = "LeaderBoardTable";
            LeaderBoardTable.RowCount = 2;
            LeaderBoardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10.27027F));
            LeaderBoardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 89.72973F));
            LeaderBoardTable.Size = new Size(212, 290);
            LeaderBoardTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 86);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "LeaderBoard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizPanel
            // 
            QuizPanel.BackColor = SystemColors.ActiveCaptionText;
            QuizPanel.Controls.Add(progressBar1);
            QuizPanel.Controls.Add(Submit);
            QuizPanel.Controls.Add(Next);
            QuizPanel.Controls.Add(Back);
            QuizPanel.Controls.Add(radioButton4);
            QuizPanel.Controls.Add(radioButton3);
            QuizPanel.Controls.Add(radioButton2);
            QuizPanel.Controls.Add(radioButton1);
            QuizPanel.Controls.Add(Question);
            QuizPanel.Controls.Add(TakeQuizButton);
            QuizPanel.Location = new Point(221, 0);
            QuizPanel.Name = "QuizPanel";
            QuizPanel.Size = new Size(588, 450);
            QuizPanel.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(53, 321);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(395, 10);
            progressBar1.TabIndex = 10;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ControlText;
            Submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = SystemColors.ButtonHighlight;
            Submit.Location = new Point(404, 346);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 62);
            Submit.TabIndex = 9;
            Submit.Text = "SUBMIT";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Next
            // 
            Next.BackColor = SystemColors.ControlText;
            Next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next.ForeColor = SystemColors.ButtonHighlight;
            Next.Location = new Point(229, 346);
            Next.Name = "Next";
            Next.Size = new Size(112, 62);
            Next.TabIndex = 8;
            Next.Text = "NEXT";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlText;
            Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ButtonHighlight;
            Back.Location = new Point(53, 346);
            Back.Name = "Back";
            Back.Size = new Size(112, 62);
            Back.TabIndex = 7;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(318, 262);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 29);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(318, 180);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(53, 262);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(53, 180);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            Question.AutoSize = true;
            Question.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Question.ForeColor = SystemColors.ButtonHighlight;
            Question.Location = new Point(53, 41);
            Question.Name = "Question";
            Question.Size = new Size(34, 32);
            Question.TabIndex = 2;
            Question.Text = "1-";
            // 
            // TakeQuizButton
            // 
            TakeQuizButton.BackColor = SystemColors.ControlText;
            TakeQuizButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            TakeQuizButton.ForeColor = SystemColors.ButtonHighlight;
            TakeQuizButton.Location = new Point(168, 124);
            TakeQuizButton.Name = "TakeQuizButton";
            TakeQuizButton.Size = new Size(241, 154);
            TakeQuizButton.TabIndex = 1;
            TakeQuizButton.Text = "START QUIZ";
            TakeQuizButton.UseVisualStyleBackColor = false;
            TakeQuizButton.Click += TakeQuizButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(QuizPanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            QuizPanel.ResumeLayout(false);
            QuizPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel QuizPanel;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button TakeQuizButton;
        private TableLayoutPanel LeaderBoardTable;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label Question;
        private Button Submit;
        private Button Next;
        private Button Back;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer LeaderBoardTimer;
        private Label Title;
    }
}