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
        private MyRequestsForm frm_myrequestsForm;
        public EditMyRequest(string requestDescription, int requestId, MyRequestsForm parrentForm)
        {
            
            InitializeComponent();
            description2 = requestDescription;
            requestId2 = requestId;
            frm_myrequestsForm = parrentForm;
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
                using (SqlCommand cmd = new SqlCommand("UpdateDescRequest", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@description", textBox1.Text);
                    cmd.Parameters.AddWithValue("@requestId", requestId2);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        MessageBox.Show("Заявка не найдена или удалена");
                        return;
                    }
                    
                    
                    if (this.Parent is Panel p)
                    {
                        p.Controls.Remove(this);
                    }

                    frm_myrequestsForm?.LoadRequests();
                    this.Close();
                }

               

            }
            MessageBox.Show("Заявка изменена");
        }
    }
}