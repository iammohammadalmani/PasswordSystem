using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                error.Visible = true;
                error.Text = "Username or password cannot be empty.";
                return;
            }//0 text length check
            if (username.Text.Length < 4 || password.Text.Length < 4)
            {
                error.Visible = true;
                error.Text = "Minumum username or password length is 5";
                return;
            }//min length check
            if (username.Text.Contains(" ") || password.Text.Contains(" "))
            {
                error.Visible = true;
                error.Text = "Username or password cannot contain spaces.";
                return;
            }//space check
            string u = username.Text;
            string p = password.Text;
            bool ok = false;

            for (int i = 0; i < UserData.count; i++)
            {
                if (UserData.usernames[i] == u && UserData.passwords[i] == p)
                {
                    ok = true;
                    break;
                }
            }

            if (ok)
            {
                error.Visible = true;
                error.ForeColor = Color.Green;
                error.Text = "Login Successful!";
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                error.Visible = true;
                error.ForeColor = Color.Red;
                error.Text = "Invalid username or password.";
            }//login check

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '•')
            {
                password.PasswordChar = '\0'; // show password
                showPassBtn.Text = "Hide";
            }
            else
            {
                password.PasswordChar = '•'; // hide password
                showPassBtn.Text = "Show";
            }
        }
    }
}
