namespace OnlineQuizPlatform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BorderStyle = BorderStyle.Fixed3D;
            WelcomeLabel.Font = new Font("Segoe UI", 16F);
            WelcomeLabel.ForeColor = SystemColors.ButtonHighlight;
            WelcomeLabel.Location = new Point(198, 119);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(378, 47);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome To PP PlatForm";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(520, 220);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 46);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(198, 220);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 2;
            label1.Text = "WindowsCount";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(289, 306);
            button1.Name = "button1";
            button1.Size = new Size(179, 59);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 494);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(WelcomeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}
