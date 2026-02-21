using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class MyRequestsForm : Form
    {
        public MyRequestsForm()
        {
            InitializeComponent();
            LoadRequests();
        }
        
        public void LoadRequests()
        {
            panel1.Controls.Clear();
            try
            {

                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
                {
                    conn.Open();



                    SqlCommand cmd = new SqlCommand("GetListRequest", conn);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", CurrentUser.userId);
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        noneRequest.Visible = true;
                        return;
                    }

                    while (reader.Read())
                    {

                        string text_id = $"Заявка №{reader["requestId"]}";
                        int requestid = Convert.ToInt32(reader["requestId"]);
                        string date = $"Дата: {Convert.ToDateTime(reader["createdData"]):HH:mm - dd.MM.yyyy}";
                        string desc = reader["faultDescription"].ToString();

                        string status = reader["repairStatusName"].ToString().ToLower();
                        
                        RequestForm rf = new RequestForm(text_id, date, desc, status, requestid, this);
                        panel1.Controls.Add(rf);
                            
                        
                    }
                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



