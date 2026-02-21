using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            using (var profileForm = new ProfileForm())
            {
                profileForm.StartPosition = FormStartPosition.CenterParent;

                profileForm.ShowDialog();

            }





        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = $"Здраствуйте {CurrentUser.RoleName} - {CurrentUser.Login}";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void newRequesRepair_btn_Click(object sender, EventArgs e)
        {

            using (var profileForm = new NewRequests())
            {
                profileForm.StartPosition = FormStartPosition.CenterParent;

                profileForm.ShowDialog();

            }
        }

        private void myRequests_btn_Click(object sender, EventArgs e)
        {
            using (var MyRequestForm = new MyRequestsForm())
            {
                MyRequestForm.StartPosition = FormStartPosition.CenterParent;

                MyRequestForm.ShowDialog();

            }
        }
    }
}
