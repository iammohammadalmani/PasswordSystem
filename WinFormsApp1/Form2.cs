using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void username21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username21.Text.Length == 0 || password21.Text.Length == 0)
            {
                error2.Visible = true;
                error2.Text = "Username or password cannot be empty.";
                return;
            }//0 text length check
            if (username21.Text.Length < 4 || password21.Text.Length < 4)
            {
                error2.Visible = true;
                error2.Text = "Minumum username or password length is 5";
                return;
            }//min length check
            if (password21 == password22)
            {
                error2.Visible = true;
                error2.Text = "Password and confirm password must be the same.";
                return;
            }//password match check
            if (username21.Text.Contains(" ") || password21.Text.Contains(" "))
            {
                error2.Visible = true;
                error2.Text = "Username or password cannot contain spaces.";
                return;
            }//space check
            for (int i = 0; i < UserData.count; i++)
            {
                if (UserData.usernames[i] == username21.Text)
                {
                    error2.Visible = true;
                    error2.Text = "Username already exists.";
                    return;
                }

            }//existing username check

            {
                string user = username21.Text;
                string pass = password21.Text;
                string pass2 = password22.Text;


                UserData.usernames[UserData.count] = user;
                UserData.passwords[UserData.count] = pass;

                UserData.count++; // move to next slot
                error2.Visible = true;
                error2.ForeColor = Color.Green;
                error2.Text = "Registration Successful!";
            }//credential check

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (password21.PasswordChar == '•')
            {
                password21.PasswordChar = '\0';  // show main password
                password22.PasswordChar = '\0';  // show confirm password
                showPassBtn2.Text = "Hide";      // change button text
            }
            else
            {
                password21.PasswordChar = '•';   // hide main password
                password22.PasswordChar = '•';   // hide confirm password
                showPassBtn2.Text = "Show";      // restore button text
            }
        }
    }
}
