using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class EditMyRequest : Form
    {
        public int requestId2;
        public string description2;
        public EditMyRequest(string requestDescription, int requestId)
        {
            
            InitializeComponent();
            description2 = requestDescription;
            requestId2 = requestId;
        }

        private void EditMyRequest_Load(object sender, EventArgs e)
        {
            textBox1.Text = description2;
        }

        private void saveDescriptionRequest_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateDescRequest",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@description", textBox1.Text);
                    cmd.Parameters.AddWithValue("@requestId", requestId2);
                    cmd.ExecuteNonQuery();
                    
                    
                }
                
                
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Заявка изменена, но для того чтобы данные поменялись нужно закрыть эту форму, удачи!");
                this.Hide();
                
                Form frm  = new MyRequestsForm();
                frm.LoadRequests()

            }
        }
    }
}