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

namespace Kursovaya
{
    public partial class RequestForm : UserControl
    {
        int requestId_form;
        string description_form;
        string text_id_form;
        string date_form;
        string status_form;
        
        public RequestForm(string text_id,string date,string description,string status, int requestid)
        {
            InitializeComponent();
            requestId_form = requestid;
            description_form = description;
            text_id_form = text_id;
            date_form = date;
            status_form = status;
            load_form();
        }
        
        private void load_form()
        {
            requestId_lb.Text = text_id_form;
            DateRequest_lb.Text = date_form;
            DescriptionRequest_lb.Text = description_form;
            StatusRequest_lb.Text = status_form;

            if (status_form.Contains("завершен"))
                StatusRequest_lb.ForeColor = Color.Green;
            else if (status_form.Contains("работе") || status_form.Contains("запчастей"))
                StatusRequest_lb.ForeColor = Color.Orange;
            else if (status_form.Contains("запчастей"))
                StatusRequest_lb.ForeColor = Color.DarkKhaki;
            else if (status_form.Contains("отмен") || status_form.Contains("отремонтировать"))
            {
                StatusRequest_lb.ForeColor = Color.Red;
                contextMenuStrip1.Items.Clear();
            }
                
            else
                StatusRequest_lb.ForeColor = Color.Blue;
        }
        

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
            {
                conn.Open();



                SqlCommand cmd = new SqlCommand("cancel_statusRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@requestId", requestId_form);
                cmd.ExecuteNonQuery();
                StatusRequest_lb.ForeColor = Color.Red;
                this.Hide();


            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new EditMyRequest(description_form, requestId_form))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Form form = new MyRequestsForm();

                    frm.Hide();
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
