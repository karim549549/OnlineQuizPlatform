using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static UserServices;

namespace OnlineQuizPlatform.Forms
{
    public partial class AppForm : Form
    {
        private readonly UserServices _userServices;


        public AppForm(UserServices userServices)
        {
            this._userServices = userServices;
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text.Trim();
            string password = usernamesign.Text.Trim();
            string name = passwordsign.Text.Trim();
            var addUserDto = new UserServices.AddUserDto(name, username, password);
            Task.Run(async () =>
            {
                try
                {

                    var user = await _userServices.SignUp(addUserDto);
                    Invoke((Action)(() =>
                    {
                        if (user != null)
                        {

                            var MainApp = new MainForm(_userServices, user);
                            this.Hide();
                            MainApp.Show();
                        }
                        else { MessageBox.Show("User Already Exists"); }

                    }));
                }
                catch (Exception ex)
                {
                    Invoke((Action)(() =>
                    {
                        MessageBox.Show($"An error occurred during signup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            });
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var user = new UserServices.UserDto(
                usernameLogin.Text.Trim(),
                Loginpassword.Text.Trim());

            Task.Run(async () =>
            {
                var foundUser = await _userServices.Login(user);

                if (foundUser == null)
                {
                    Invoke((Action)(() =>
                    {
                        MessageBox.Show("InCorrect Credentials");
                    }));
                }
                Invoke((Action)(() =>
                {
                    var MainApp = new MainForm(_userServices, foundUser);
                    this.Hide();
                    MainApp.Show();

                }));
            });
        }



        private async void ToggleLoginSignUp(bool showLoginPanel)
        {
            if (showLoginPanel)
            {
                SignUpPanel.Visible = false;
                LoginPanel.Visible = true;
            }
            else
            {
                LoginPanel.Visible = false;
                SignUpPanel.Visible = true;
            }
        }


        private void LoginToggle_Click(object sender, EventArgs e)
        {
            ToggleLoginSignUp(true);
        }

        private void SignUpToggle_Click(object sender, EventArgs e)
        {
            ToggleLoginSignUp(false);
        }
    }
}
