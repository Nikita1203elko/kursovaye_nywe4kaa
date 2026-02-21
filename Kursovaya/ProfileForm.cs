using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void saveProfile_btn_Click(object sender, EventArgs e)
        {
            string firstName = firstName_tb.Text;
            string lastName = lastName_tb.Text;
            string email = email_tb.Text;
            string phone = numberPhone_tb.Text;

            CurrentUser.UpdateUserInfo(CurrentUser.Login, firstName, lastName, email, phone);
            CurrentUser.GetUserInfo(CurrentUser.Login);
            MessageBox.Show("Данные обновленны");
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            firstName_tb.Text = CurrentUser.firstName;
            lastName_tb.Text = CurrentUser.lastName;
            email_tb.Text = CurrentUser.email;
            numberPhone_tb.Text = CurrentUser.phone;
        }
    }
}
