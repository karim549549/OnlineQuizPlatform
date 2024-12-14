namespace OnlineQuizPlatform.Forms
{
    partial class AppForm
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            LoginPanel = new Panel();
            LoginButton = new Button();
            label2 = new Label();
            Loginpassword = new TextBox();
            label1 = new Label();
            usernameLogin = new TextBox();
            SignUpPanel = new Panel();
            label5 = new Label();
            nameBox = new TextBox();
            SignUpButton = new Button();
            label3 = new Label();
            passwordsign = new TextBox();
            label4 = new Label();
            usernamesign = new TextBox();
            panel1.SuspendLayout();
            LoginPanel.SuspendLayout();
            SignUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 449);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(3, 210);
            button2.Name = "button2";
            button2.Size = new Size(148, 58);
            button2.TabIndex = 1;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(3, 125);
            button1.Name = "button1";
            button1.Size = new Size(148, 58);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.ActiveCaptionText;
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(Loginpassword);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(usernameLogin);
            LoginPanel.Location = new Point(510, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(289, 449);
            LoginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(110, 305);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(131, 61);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 193);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Loginpassword
            // 
            Loginpassword.Location = new Point(110, 187);
            Loginpassword.Name = "Loginpassword";
            Loginpassword.Size = new Size(160, 31);
            Loginpassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 95);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // usernameLogin
            // 
            usernameLogin.Location = new Point(110, 95);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(160, 31);
            usernameLogin.TabIndex = 2;
            // 
            // SignUpPanel
            // 
            SignUpPanel.BackColor = SystemColors.ActiveCaptionText;
            SignUpPanel.Controls.Add(label5);
            SignUpPanel.Controls.Add(nameBox);
            SignUpPanel.Controls.Add(SignUpButton);
            SignUpPanel.Controls.Add(label3);
            SignUpPanel.Controls.Add(passwordsign);
            SignUpPanel.Controls.Add(label4);
            SignUpPanel.Controls.Add(usernamesign);
            SignUpPanel.ForeColor = SystemColors.ButtonFace;
            SignUpPanel.Location = new Point(157, 0);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(347, 449);
            SignUpPanel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 55);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 8;
            label5.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(132, 52);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(202, 31);
            nameBox.TabIndex = 7;
            // 
            // SignUpButton
            // 
            SignUpButton.ForeColor = SystemColors.ActiveCaptionText;
            SignUpButton.Location = new Point(132, 305);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(131, 61);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "SignUp";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 219);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // passwordsign
            // 
            passwordsign.Location = new Point(132, 216);
            passwordsign.Name = "passwordsign";
            passwordsign.Size = new Size(202, 31);
            passwordsign.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(26, 145);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // usernamesign
            // 
            usernamesign.Location = new Point(132, 142);
            usernamesign.Name = "usernamesign";
            usernamesign.Size = new Size(202, 31);
            usernamesign.TabIndex = 2;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignUpPanel);
            Controls.Add(LoginPanel);
            Controls.Add(panel1);
            Name = "AppForm";
            Text = "AppForm";
            panel1.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            SignUpPanel.ResumeLayout(false);
            SignUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel LoginPanel;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox Loginpassword;
        private Label label1;
        private Button LoginButton;
        private Panel SignUpPanel;
        private Label label5;
        private TextBox nameBox;
        private Button SignUpButton;
        private Label label3;
        private TextBox passwordsign;
        private Label label4;
        private TextBox usernamesign;
        private TextBox usernameLogin;
    }
}