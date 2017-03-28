using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPSAddUserForm
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        /******************************************************************************
         * private void addButton_Click(object sender, EventArgs e)
         * 
         * @ instantiates new User based on data submitted in AddUserForm text boxes
         * @ params: object sender, EventArgs e
         * @ returns: NA
         * 
        ******************************************************************************/
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
            // instantiate new User
            User theNewUser = new User();

            // specify user attributes
            theNewUser.userID = this.mNumberBox.Text;
            theNewUser.FirstName = this.firstNameBox.Text;
            theNewUser.lastName = this.lastNameBox.Text;
            theNewUser.userName = this.userNameBox.Text;
            theNewUser.passWord = this.passWordBox.Text;

            // send User object to Database Manager- so indicate if no joy
            bool success = DatabaseManager.InsertUser(theNewUser);
                if (!success) MessageBox.Show("User not added.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There's no data.");
            }
            this.Hide();
        }
    }
}
