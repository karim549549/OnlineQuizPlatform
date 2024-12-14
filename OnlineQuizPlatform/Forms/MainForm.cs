using OnlineQuizPlatform.Domain;

namespace OnlineQuizPlatform.Forms
{
    public partial class MainForm : Form
    {
        private readonly UserServices _userServices;
        private int _currentQuestionIndex = 0;
        private List<Question> _quiz = new();
        private Dictionary<int, int> _userAnswers = new();
        private readonly User _user;
        public MainForm(UserServices userServices ,User user)
        {
            _user= user;
            _userServices = userServices;
            InitializeComponent();
        }
        private async void TakeQuizButton_Click(object sender, EventArgs e)
        {
            ToggleQuizContent(true);
            var quiz = await GetAQuiz();

            if (quiz == null || !quiz.Any())
            {
                MessageBox.Show("No quiz questions available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ToggleQuizContent(false);
                return;
            }

            _quiz = quiz;
            _currentQuestionIndex = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            DisplayQuestion(_quiz[_currentQuestionIndex], _currentQuestionIndex + 1);
        }
        private void DisplayQuestion(Question question, int index)
        {
            if (question == null)
            {
                MessageBox.Show("Invalid question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Question.Text = $"{index}- {question.Text}";

            radioButton1.Text = question.Options[0];
            radioButton1.Tag = 0;
            radioButton1.Checked = false;

            radioButton2.Text = question.Options[1];
            radioButton2.Tag = 1;
            radioButton2.Checked = false;

            radioButton3.Text = question.Options[2];
            radioButton3.Tag = 2;
            radioButton3.Checked = false;

            radioButton4.Text = question.Options[3];
            radioButton4.Tag = 3;
            radioButton4.Checked = false;

            if (_userAnswers.ContainsKey(question.Id))
            {
                int previousAnswer = _userAnswers[question.Id];
                switch (previousAnswer)
                {
                    case 0: radioButton1.Checked = true; break;
                    case 1: radioButton2.Checked = true; break;
                    case 2: radioButton3.Checked = true; break;
                    case 3: radioButton4.Checked = true; break;
                }
            }

            Back.Enabled = _currentQuestionIndex > 0;
            Next.Enabled = _currentQuestionIndex < _quiz.Count - 1;
            Submit.Enabled = _currentQuestionIndex == _quiz.Count - 1;


            UpdateProgressBar(0);
        }
        private async Task<List<Question>?> GetAQuiz()
        {
            return await Task.Run(async () =>
            {
                try
                {
                    var quiz = await _userServices.GetQuiz();
                    return quiz;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching the quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            });
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex >= _quiz.Count - 1)
            {
                MessageBox.Show("You are already on the last question.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveAnswer(_quiz[_currentQuestionIndex].Id);
            _currentQuestionIndex++;

            DisplayQuestion(_quiz[_currentQuestionIndex], _currentQuestionIndex + 1);
            UpdateProgressBar(1); 
        }
        private void Back_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex <= 0)
            {
                MessageBox.Show("You are already on the first question.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveAnswer(_quiz[_currentQuestionIndex].Id);
            _currentQuestionIndex--;

            DisplayQuestion(_quiz[_currentQuestionIndex], _currentQuestionIndex + 1);
            UpdateProgressBar(_currentQuestionIndex); 
        }
        private async void Submit_Click(object sender, EventArgs e)
        {
            SaveAnswer(_quiz[_currentQuestionIndex].Id);

            int totalScore = 0;
            foreach (var question in _quiz)
            {
                if (_userAnswers.ContainsKey(question.Id) &&
                    _userAnswers[question.Id] == question.CorrectAnswerIndex)
                {
                    totalScore += question.Score;
                }
            }
            await _userServices.UpdateScore(totalScore, _user.Id);
             
            MessageBox.Show($"Quiz completed! Your total score is: {totalScore}", "Quiz Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            _quiz.Clear();
            _currentQuestionIndex = 0;
            _userAnswers.Clear();


            ToggleQuizContent(false);
            LoadLeaderBoard();
        }
        private void SaveAnswer(int questionId)
        {
            int selectedOption = -1;

            if (radioButton1.Checked) selectedOption = (int)radioButton1.Tag;
            else if (radioButton2.Checked) selectedOption = (int)radioButton2.Tag;
            else if (radioButton3.Checked) selectedOption = (int)radioButton3.Tag;
            else if (radioButton4.Checked) selectedOption = (int)radioButton4.Tag;

            if (selectedOption != -1)
            {
                _userAnswers[questionId] = selectedOption;
            }
        }
        private void UpdateProgressBar(int step)
        {
            int progress = (int)((double)(_currentQuestionIndex + step + 1) / _quiz.Count * 100);
            progress = Math.Max(0, Math.Min(progress, 100));
            progressBar1.Value = progress;
        }
        private void ToggleQuizContent(bool showQuizContent)
        {
            foreach (Control control in QuizPanel.Controls)
            {
                if (control != TakeQuizButton)
                {
                    control.Visible = showQuizContent;
                }
            }
            TakeQuizButton.Visible = !showQuizContent;
        }
        private void InitializeTimer()
        {
            LeaderBoardTimer = new System.Windows.Forms.Timer();
            LeaderBoardTimer.Interval = 60*1000; 
            LeaderBoardTimer.Tick += async (s, e) => await LoadLeaderBoard();
            LeaderBoardTimer.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadLeaderBoard();
            Title.Text = $"Welcome , {_user.Name}";
            Title.Padding = new Padding(1);
            this.Padding = new Padding(1);
            InitializeTimer();
            ToggleQuizContent(false);
        }
        private void InitializeLeaderBoard()
        {
            LeaderBoardTable.Controls.Clear();
            LeaderBoardTable.ColumnStyles.Clear();
            LeaderBoardTable.RowStyles.Clear();

            LeaderBoardTable.ColumnCount = 2;
            LeaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            LeaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

            AddLeaderBoardRow("Name", "Score", isHeader: true);
        }
        private async Task LoadLeaderBoard()
        {
            try
            {
                var leaderBoardData = await Task.Run(() => _userServices.GetLeaderBoard());

                if (LeaderBoardTable.RowCount - 1 != leaderBoardData.Count)
                {
                    InitializeLeaderBoard();
                    foreach (var user in leaderBoardData)
                    {
                        AddLeaderBoardRow(user.Name, user.Score.ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < leaderBoardData.Count; i++)
                    {
                        var nameLabel = (Label)LeaderBoardTable.GetControlFromPosition(0, i + 1);
                        var scoreLabel = (Label)LeaderBoardTable.GetControlFromPosition(1, i + 1);

                        if (nameLabel != null && scoreLabel != null)
                        {
                            nameLabel.Text = leaderBoardData[i].Name;
                            scoreLabel.Text = leaderBoardData[i].Score.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the leaderboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLeaderBoardRow(string name, string score, bool isHeader = false)
        {
            var nameLabel = new Label
            {
                Text = name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = isHeader ? new Font("Segoe UI", 8F, FontStyle.Bold) : new Font("Segoe UI", 8F),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };

            var scoreLabel = new Label
            {
                Text = score,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = isHeader ? new Font("Segoe UI", 8F, FontStyle.Bold) : new Font("Segoe UI", 8F),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };

            LeaderBoardTable.RowCount++;
            LeaderBoardTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            LeaderBoardTable.Controls.Add(nameLabel, 0, LeaderBoardTable.RowCount - 1); // Name column
            LeaderBoardTable.Controls.Add(scoreLabel, 1, LeaderBoardTable.RowCount - 1); // Score column
        }
    }
}
