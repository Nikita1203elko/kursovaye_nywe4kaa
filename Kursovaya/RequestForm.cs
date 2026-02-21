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
        
        private MyRequestsForm frm_myrequestsForm;
        public RequestForm(string text_id,string date,string description,string status, int requestid, MyRequestsForm parentForm)
        {
            InitializeComponent();
            requestId_form = requestid;
            description_form = description;
            text_id_form = text_id;
            date_form = date;
            status_form = status;
            load_form();
            frm_myrequestsForm = parentForm;
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
            try
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.bd_connect))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("cancel_statusRequest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@requestId", requestId_form);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows == 0)
                        {
                            MessageBox.Show("Заявка не найдена или уже отменена");
                            return;
                        }
                    }
                }
                MessageBox.Show("Статус изменён");
                
                if (this.Parent is Panel p)
                {
                    p.Controls.Remove(this);
                }

                frm_myrequestsForm?.LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отмене:\n" + ex.Message);
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new EditMyRequest(description_form, requestId_form,frm_myrequestsForm))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm_myrequestsForm.LoadRequests();
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
