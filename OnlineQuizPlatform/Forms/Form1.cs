using OnlineQuizPlatform.Forms;

namespace OnlineQuizPlatform
{
    public partial class Form1 : Form
    {
        private readonly UserServices _userServices;
        public Form1(UserServices userServices)
        {
            this._userServices = userServices;
            InitializeComponent();
            this.WelcomeLabel.Padding = new Padding(10);
            this.label1.Padding = new Padding(8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBox1.Text, out int numberOfWindows) && numberOfWindows > 0)
            {
                for (int i = 0; i < numberOfWindows; i++)
                {
                    CreateNewWindow();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateNewWindow()
        {
            
            var thread = new Thread(() =>
            {
                var appForm = new AppForm(_userServices);
                Application.Run(appForm);
            });

            thread.SetApartmentState(ApartmentState.STA); 
            thread.IsBackground = true; 
            thread.Start();
        }


    }
}
