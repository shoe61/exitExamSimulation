using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExitExamApp
{
    public partial class LoginForm : Form
    {
        User user = new User();
        public LoginForm()
        {
            InitializeComponent();
       
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamMenuForm ss = new ExamMenuForm();
            ss.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            string userName = user.UserName;
            if (e.KeyCode == Keys.Enter)
            {
                if(userNameBox.Text != userName)
                {
                    MessageBox.Show("Invalid Username or Password. Try again.", "Error!", MessageBoxButtons.OK);
                    userNameBox.Text = "";
                }
                else
                {
                    passBox.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                
            }
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)
        {
            string passWord = user.PassWord;
            if(e.KeyCode == Keys.Enter)
            {
                if(passBox.Text != passWord)
                {
                    MessageBox.Show("Invalid Username or Password. Try again.", "Error!", MessageBoxButtons.OK);
                    passBox.Text = "";
                }
                else
                {
                    loginButton.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
               
            }
        }
    }
}
