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
    public partial class ExitExam : Form
    {
        private int exitCode;

        public ExitExam()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void exitExamButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(exitCode);
        }
    }
}
