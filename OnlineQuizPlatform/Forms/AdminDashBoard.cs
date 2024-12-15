using OnlineQuizPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuizPlatform.Forms
{
    public partial class AdminDashBoard : Form
    {
        private readonly UserServices _userServices;
        private readonly User _user;

        private System.Threading.Timer _dataReloadTimer; // Thread Timer

        public AdminDashBoard(UserServices userServices, User user)
        {
            InitializeComponent();
            _userServices = userServices;
            _user = user;

            UserPanel.Hide();
            InitializeDataGrids();

            StartDataReloadTimer();
        }

        // Initialize DataGrids
        private void InitializeDataGrids()
        {
            UserDataGrid.AutoGenerateColumns = false;
            UserDataGrid.Columns.Clear();

            UserDataGrid.Columns.Add("Id", "ID");
            UserDataGrid.Columns.Add("Name", "Name");
            UserDataGrid.Columns.Add("Score", "Score");

            QuestionDataGrid.AutoGenerateColumns = false;
            QuestionDataGrid.Columns.Clear();

            QuestionDataGrid.Columns.Add("Text", "Question Text");
            QuestionDataGrid.Columns.Add("Answer", "Answer");
        }

        // Start the Thread Timer to reload data every 5 seconds
        private void StartDataReloadTimer()
        {
            _dataReloadTimer = new System.Threading.Timer(async state =>
            {
                await ReloadAllData();
            }, null, 0, 5000); // Timer interval: 5000 ms (5 seconds)
        }

        // Reload both grids in the background
        private async Task ReloadAllData()
        {
            if (UserPanel.Visible)
            {
                await LoadUsers();
            }
            else if (QuestionPanel.Visible)
            {
                await LoadQuestions();
            }
        }

        // Event for Question Button Click
        private async void QuestionButton_Click(object sender, EventArgs e)
        {
            UserPanel.Hide();
            QuestionPanel.Show();
            await LoadQuestions();
        }

        // Load Questions into DataGridView
        private async Task LoadQuestions()
        {
            try
            {
                var questions = await _userServices.GetQuestionsAsync();

                Invoke((Action)(() =>
                {
                    QuestionDataGrid.Rows.Clear();
                    foreach (var question in questions)
                    {
                        QuestionDataGrid.Rows.Add(question.Text, question.Options[question.CorrectAnswerIndex]);
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load questions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event for User Button Click
        private async void UserButton_Click(object sender, EventArgs e)
        {
            QuestionPanel.Hide();
            UserPanel.Show();
            await LoadUsers();
        }

        // Load Users into DataGridView
        private async Task LoadUsers()
        {
            try
            {
                var users = await _userServices.GetUsersAsync();

                Invoke((Action)(() =>
                {
                    UserDataGrid.Rows.Clear();
                    foreach (var user in users)
                    {
                        UserDataGrid.Rows.Add(user.Id, user.Name, user.Score);
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Dispose of the timer when the form is closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _dataReloadTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
