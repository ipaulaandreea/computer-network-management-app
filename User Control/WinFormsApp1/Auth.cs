namespace WinFormsApp1
{
    public partial class Auth : UserControl
    {
        public event EventHandler<(string Username, string Password)> LoginRequested;

        public Auth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            var username = tbUser.Text.Trim();
            var password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please fill in both fields.";
                return;
            }

            lblError.Text = "";
            LoginRequested?.Invoke(this, (username, password));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}